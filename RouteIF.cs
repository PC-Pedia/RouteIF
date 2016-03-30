using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RouteIF
{
    public partial class RouteIF : Form
    {
        private BindingList<NetInterface> m_bindingList = new BindingList<NetInterface>();
        private FormBorderStyle m_initialFormBorderStyle;
        private bool m_bChanging;

        public RouteIF()
        {
            InitializeComponent();
            m_cbNetInterface.DisplayMember = "Description";
            m_cbNetInterface.ValueMember = "DefaultGateway";
            m_cbNetInterface.DataSource = m_bindingList;
            m_toolStripComboBox.ComboBox.DisplayMember = m_cbNetInterface.DisplayMember;
            m_toolStripComboBox.ComboBox.ValueMember = m_cbNetInterface.ValueMember;
            m_toolStripComboBox.ComboBox.DataSource = m_cbNetInterface.DataSource;
            m_toolStripComboBox.ComboBox.BindingContext = BindingContext;
            m_initialFormBorderStyle = FormBorderStyle;
            m_bChanging = false;
        }

        private NetInterface GetNetInterfaceByDescription(string sDescription)
        {
            return m_bindingList.Single(s => s.Description == sDescription);
        }

        private NetInterface GetNetInterfaceByDefaultGetway(string sDefaultGetway)
        {
            return m_bindingList.Single(s => s.DefaultGateway == sDefaultGetway);
        }

        private void Reload()
        {
            m_bindingList.Clear();
            foreach (NetInterface ni in Command.GetNetInterfaces())
            {
                m_bindingList.Add(ni);
            }
            string sDefaultGetway = Command.GetDefaultGetway();
            NetInterface netInterface = GetNetInterfaceByDefaultGetway(sDefaultGetway);
            ChangeSelection(m_cbNetInterface.FindString(netInterface.Description));
        }

        private void OnResize(FormWindowState windowState)
        {
            if (FormWindowState.Minimized == windowState)
            {
                m_notifyIcon.Visible = true;
                Hide();
                ShowInTaskbar = false;
                m_toolStripComboBox.Visible = true;
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            else if (FormWindowState.Normal == windowState)
            {
                m_notifyIcon.Visible = false;
                ShowInTaskbar = true;
                m_toolStripComboBox.Visible = true;
                FormBorderStyle = m_initialFormBorderStyle;
            }
        }

        private void ChangeSelection(int index, NetInterface selectedNetInterface = null)
        {
            m_bChanging = true;
            if (selectedNetInterface != null)
            {
                bool bOk = Command.SetDefaultGetway(selectedNetInterface.DefaultGateway);
            }
            m_cbNetInterface.SelectedIndex = index;
            m_toolStripComboBox.ComboBox.SelectedIndex = index;
            m_bChanging = false;
        }

        private void RouteIF_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void m_cbNetInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_bChanging)
                return;
            ChangeSelection(m_cbNetInterface.SelectedIndex, (NetInterface) m_cbNetInterface.SelectedItem);
        }

        private void m_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_bChanging)
                return;
            ChangeSelection(m_toolStripComboBox.SelectedIndex, (NetInterface) m_toolStripComboBox.SelectedItem);
        }

        private void RouteIF_Resize(object sender, EventArgs e)
        {
            OnResize(WindowState);
        }

        private void m_notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            OnResize(WindowState = FormWindowState.Normal);
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
