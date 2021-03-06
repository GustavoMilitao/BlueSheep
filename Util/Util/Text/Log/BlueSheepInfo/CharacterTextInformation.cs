﻿using Util.Util.I18n.Strings;
using System.Drawing;

namespace Util.Util.Text.Log
{
    public class CharacterTextInformation : TextInformation
    {
        #region Fields
        private string m_Text;
        private string m_Category;
        #endregion

        #region Properties
        public override string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public override Color Color
        {
            get { return Color.Chocolate; }
        }

        public override string Category
        {
            get { return Strings.General; }
            set { m_Category = value; }
        }



        public override string Account { get; set; }
        #endregion
        
        #region Constructeurs
        public CharacterTextInformation(string text)
        {
            m_Text = text;
        }
        #endregion
    }
}
