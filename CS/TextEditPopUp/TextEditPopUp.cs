using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace TEPopUp
{
    class TextEditPopUp : PopupContainerEdit
    {
        static TextEditPopUp() { RepositoryItemTextEditPopUp.RegisterTextEditPopUp(); }
        public TextEditPopUp() : base() { }
        public override string EditorTypeName { get { return RepositoryItemTextEditPopUp.TextEditPopUpName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemTextEditPopUp Properties
        { get { return base.Properties as RepositoryItemTextEditPopUp; } }

        public virtual object DataSource
        {
            set { Properties.DataSource = value; }
            get { return Properties.DataSource; }
        }

        public virtual string DisplayMember
        {
            set { Properties.DisplayMember = value; }
            get { return Properties.DisplayMember; }
        }
    }
}
