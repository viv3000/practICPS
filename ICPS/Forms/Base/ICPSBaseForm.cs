using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICPS.Forms.Base
{
	public class ICPSBaseForm : Form
	{
		protected bool IsFiled(Label label)
		{
			return (label.Text.Replace(" ", "") != "");
		}
	}
}
