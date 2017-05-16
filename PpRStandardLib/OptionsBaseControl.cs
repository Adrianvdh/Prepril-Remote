using System;
using System.Windows.Forms;

namespace Configuration
{
	public abstract class OptionsBaseControl : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.Container components = null;

		private readonly string m_configurationName;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="configName">name of the configuration</param>
		public OptionsBaseControl(string configName) : base()
		{
			m_configurationName = configName;
			this.Anchor = AnchorStyles.Right | AnchorStyles.Left;
		}

		public string GetConfigurationName() { return m_configurationName; }

		/// <summary>
		/// Saves changes made to this control
		/// </summary>
		//public abstract void Apply();
		/// <summary>
		/// Restores state of the control
		/// </summary>
		//public abstract void Restore();

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // OptionsBaseControl
            // 
            this.Name = "OptionsBaseControl";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Load += new System.EventHandler(this.OptionsBaseControl_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private void OptionsBaseControl_Load(object sender, EventArgs e)
        {

        }
	}
}
