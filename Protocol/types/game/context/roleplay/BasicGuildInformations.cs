﻿using MageBot.Protocol.Types.Game.Social;

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{
    public class BasicGuildInformations : AbstractSocialGroupInfos
    {
        protected override int ProtocolId { get; set; } = 365;
        public override int TypeID { get { return ProtocolId; } }

        public uint GuildId;
        public string GuildName;
        public sbyte GuildLevel;

        public BasicGuildInformations() { }

        public BasicGuildInformations(uint guildId, string guildName, sbyte guildLevel)
        {
            GuildId = guildId;
            GuildName = guildName;
            GuildLevel = guildLevel;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(GuildId);
            writer.WriteUTF(GuildName);
            writer.WriteSByte(GuildLevel);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            GuildId = reader.ReadVarUhInt();
            GuildName = reader.ReadUTF();
            GuildLevel = reader.ReadSByte();
        }
    }
}
