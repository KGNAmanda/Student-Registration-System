using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentRegistrationSystem
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
            // try to load an embedded logo if present (optional)
            try
            {
                // Prefer the shared loader in the designer partial; it checks multiple locations and resources
                ImageUtil.LoadImage(this.picLogo, "logo.png");
            }
            catch
            {
                // ignore image load errors
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

// Image helper included directly to avoid needing csproj edits
internal static class ImageUtil
{
    public static void LoadImage(System.Windows.Forms.PictureBox pb, string filename)
    {
        if (pb == null || string.IsNullOrWhiteSpace(filename)) return;
        try
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] candidates = new string[] {
                System.IO.Path.Combine(baseDir, filename),
                System.IO.Path.Combine(Environment.CurrentDirectory, filename),
                System.IO.Path.Combine(baseDir, "Resources", filename),
                System.IO.Path.Combine(baseDir, "Images", filename),
            };

            foreach (var path in candidates)
            {
                if (System.IO.File.Exists(path))
                {
                    var old = pb.Image;
                    try { pb.Image = System.Drawing.Image.FromFile(path); }
                    finally { old?.Dispose(); }
                    return;
                }
            }

            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            var names = asm.GetManifestResourceNames();
            foreach (var res in names)
            {
                if (res.EndsWith(filename, StringComparison.OrdinalIgnoreCase))
                {
                    using (var s = asm.GetManifestResourceStream(res))
                    {
                        if (s != null)
                        {
                            using (var img = System.Drawing.Image.FromStream(s))
                            {
                                pb.Image = new System.Drawing.Bitmap(img);
                            }
                            return;
                        }
                    }
                }
            }

            var resType = asm.GetType(asm.GetName().Name + ".Properties.Resources");
            if (resType != null)
            {
                var propName = System.IO.Path.GetFileNameWithoutExtension(filename);
                var prop = resType.GetProperty(propName, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                if (prop != null)
                {
                    var val = prop.GetValue(null, null);
                    if (val is System.Drawing.Image imgVal)
                    {
                        pb.Image = new System.Drawing.Bitmap(imgVal);
                        return;
                    }
                }
            }
        }
        catch
        {
            // ignore
        }
    }
}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Basic placeholder logic: accept if both fields provided.
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Check hard-coded single user credentials
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Skills@123")
            {
                // Hide login and open registration form
                this.Hide();
                using (var reg = new FormRegistration())
                {
                    reg.ShowDialog();
                }
                // when registration form is closed, show login again
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }
    }
}
