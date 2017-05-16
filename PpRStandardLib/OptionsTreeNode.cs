using System;
using System.Windows.Forms;

namespace Configuration
{
	public class ConfigTreeNode : TreeNode
	{
		/// <summary>
		/// the user control that is related to the configuration tree node
		/// </summary>
        private OptionsBaseControl m_userControl;

        public ConfigTreeNode(string nodeName, OptionsBaseControl relatedControl) : base(nodeName)
		{
			m_userControl = relatedControl;
			m_userControl.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
		}

		/// <summary>
		/// Get the name of the configuration item
		/// </summary>
		/// <returns></returns>
		public string GetConfigurationName()
		{
			return m_userControl.GetConfigurationName();
		}

		/// <summary>
		/// Get the related configuration control
		/// </summary>
		/// <returns></returns>
        public OptionsBaseControl GetConfigurationControl() { return m_userControl; }
	}
}
