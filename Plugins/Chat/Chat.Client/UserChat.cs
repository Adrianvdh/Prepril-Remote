using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chat_Client
{
    public partial class UserChat : Form
    {
        public UserChat()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ConnectedUsersListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(UserChatListView.Handle, "explorer", null);
            UserChatListView.ContextMenu = ChatContextMenu;
        }

        private void UserChat_Load(object sender, EventArgs e)
        {

        }
    }
}
