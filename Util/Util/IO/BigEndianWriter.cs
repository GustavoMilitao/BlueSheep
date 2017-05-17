﻿using System;
using System.IO;
using System.Text;

namespace MageBot.Util.IO
{
    [Serializable]
    public class BigEndianWriter : IDisposable, IDataWriter
    {

        #region new BigEndianWriter

        #region Properties
        public byte[] Content
        {
            get
            {
                byte[] content = new byte[BaseStream.Length];

                BaseStream.Position = 0;
                BaseStream.Read(content, 0, (int)BaseStream.Length);

                return content;
            }
            set
            {
                BaseStream.Position = 0;
                BaseStream.Write(value, 0, value.Length);
            }
        }
        #endregion


        #region Dispose

        public void Dispose()
        {
            m_writer.Dispose();
            m_writer = null;
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Reverse bytes and write them into the buffer
        /// </summary>
        private void WriteBigEndianBytes(byte[] endianBytes)
        {
            for (var i = endianBytes.Length - 1; i >= 0; i--)
            {
                m_writer.Write(endianBytes[i]);
            }
        }

        #endregion

        #region Properties

        private BinaryWriter m_writer;

        public Stream BaseStream
        {
            get { return m_writer.BaseStream; }
        }

        /// <summary>
        ///     Gets available bytes number in the buffer
        /// </summary>
        public long BytesAvailable
        {
            get { return m_writer.BaseStream.Length - m_writer.BaseStream.Position; }
        }

        public long Position
        {
            get { return m_writer.BaseStream.Position; }
            set { m_writer.BaseStream.Position = value; }
        }

        public byte[] Data
        {
            get
            {
                var pos = m_writer.BaseStream.Position;

                var data = new byte[m_writer.BaseStream.Length];
                m_writer.BaseStream.Position = 0;
                m_writer.BaseStream.Read(data, 0, (int)m_writer.BaseStream.Length);

                m_writer.BaseStream.Position = pos;

                return data;
            }
        }

        #endregion

        #region Initialisation

        /// <summary>
        ///     Initializes a new instance of the <see cref="BigEndianWriter" /> class.
        /// </summary>
        public BigEndianWriter()
        {
            m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BigEndianWriter" /> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public BigEndianWriter(Stream stream)
        {
            m_writer = new BinaryWriter(stream, Encoding.UTF8);
        }

        public BigEndianWriter(byte[] buffer)
        {
            m_writer = new BinaryWriter(new MemoryStream(buffer));
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Write a Short into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteShort(short @short)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@short));
        }

        /// <summary>
        ///     Write a int into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteInt(int @int)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@int));
        }

        /// <summary>
        ///     Write a long into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteLong(long @long)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@long));
        }

        /// <summary>
        ///     Write a UShort into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUShort(ushort @ushort)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@ushort));
        }

        /// <summary>
        ///     Write a int into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUInt(uint @uint)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@uint));
        }

        /// <summary>
        ///     Write a long into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteULong(ulong @ulong)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@ulong));
        }

        /// <summary>
        ///     Write a byte into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteByte(byte @byte)
        {
            m_writer.Write(@byte);
        }

        public void WriteSByte(sbyte @byte)
        {
            m_writer.Write(@byte);
        }

        /// <summary>
        ///     Write a Float into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteFloat(float @float)
        {
            m_writer.Write(@float);
        }

        /// <summary>
        ///     Write a Boolean into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBoolean(bool @bool)
        {
            if (@bool)
            {
                m_writer.Write((byte)1);
            }
            else
            {
                m_writer.Write((byte)0);
            }
        }

        /// <summary>
        ///     Write a Char into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteChar(char @char)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@char));
        }

        /// <summary>
        ///     Write a Double into the buffer
        /// </summary>
        public void WriteDouble(double @double)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@double));
        }

        /// <summary>
        ///     Write a Single into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteSingle(float @single)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@single));
        }

        /// <summary>
        ///     Write a string into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUTF(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var len = (ushort)bytes.Length;
            WriteUShort(len);

            int i;
            for (i = 0; i < len; i++)
                m_writer.Write(bytes[i]);
        }

        /// <summary>
        ///     Write a string into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUTFBytes(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var len = bytes.Length;
            int i;
            for (i = 0; i < len; i++)
                m_writer.Write(bytes[i]);
        }

        /// <summary>
        ///     Write a bytes array into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBytes(byte[] data)
        {
            m_writer.Write(data);
        }

        /// <summary>
        ///     Write a bytes array into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBytes(byte[] data, uint offset, uint length)
        {
            var array = new byte[length];
            Array.Copy(data, offset, array, 0, length);
            m_writer.Write(array);
        }

        public void Seek(int offset, SeekOrigin seekOrigin)
        {
            m_writer.BaseStream.Seek(offset, seekOrigin);
        }

        public void Clear()
        {
            m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        #endregion

        #region Custom Methods

        public void WriteVarShort(short @int)
        {
            WriteVar((ushort)@int);
        }

        public void WriteVarShort(ushort @uint)
        {
            WriteVar(@uint);
        }

        public void WriteVarInt(int @int)
        {
            WriteVar((uint)@int);
        }

        public void WriteVarInt(uint @uint)
        {
            WriteVar(@uint);
        }

        public void WriteVarLong(long @long)
        {
            WriteVar((ulong)@long);
        }

        public void WriteVarLong(ulong @ulong)
        {
            WriteVar(@ulong);
        }

        private void WriteVar(ulong number)
        {
            while (number > 127)
            {
                WriteByte((byte)((number & 127) | 128));
                number >>= 7;
            }
            WriteByte((byte)number);
        }

        #endregion

        #endregion
    }
}
