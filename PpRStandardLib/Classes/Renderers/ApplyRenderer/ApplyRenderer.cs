using System.Drawing;
using System.Windows.Forms;
using System3DRenderer;
using Szotar.WindowsForms;
using System.Windows.Forms.VisualStyles;

namespace ApplyRenderers
{

        #region System3DToolStripRenderer
        class System3DToolStripRenderer : ToolStripProfessionalRenderer
        {
            public System3DToolStripRenderer() : base(new System3DColorTable())
            {
                //do nothing
            }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }
        #endregion

        #region SystemToolStripRenderer
        public class SystemToolStripRenderer : ToolStripSystemRenderer
        {
            public SystemToolStripRenderer() { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }
        #endregion

        #region ListView
        //VistaControls.VistaConstants.SetWindowTheme(EventsListView.Handle, "explorer", null);
        //VistaControls.VistaConstants.SendMessage(EventsListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
        #endregion

        #region TreeView
        //VistaControls.VistaConstants.SendMessage(AddressesTreeView.Handle, VistaControls.VistaConstants.TVM_SETEXTENDEDSTYLE, VistaControls.VistaConstants.TVS_EX_FADEINOUTEXPANDOS, VistaControls.VistaConstants.TVS_EX_FADEINOUTEXPANDOS);
        //VistaControls.VistaConstants.SendMessage(AddressesTreeView.Handle, VistaControls.VistaConstants.TVM_SETEXTENDEDSTYLE, VistaControls.VistaConstants.TVS_EX_AUTOHSCROLL, VistaControls.VistaConstants.TVS_EX_AUTOHSCROLL);
        #endregion

  
}
