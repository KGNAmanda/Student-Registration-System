using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentRegistrationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ensure UI image files are available in the application folder so ImageUtil can load them.
            try
            {
                EnsureImagesPresent();
            }
            catch
            {
                // ignore errors - ImageUtil will fallback
            }
            Application.Run(new Form1Login());
        }

        private static void EnsureImagesPresent()
        {
            string[] filenames = new[] { "logo.png", "side_banner.jpg", "header_banner.jpg" };
            string appBase = AppDomain.CurrentDomain.BaseDirectory;

            // potential source folders to look for the images during development
            string projectImages = Path.GetFullPath(Path.Combine(appBase, "..", "..", "..", "Images"));
            string projectRoot = Path.GetFullPath(Path.Combine(appBase, "..", "..", ".."));
            string[] candidates = new[] {
                projectImages,
                Path.Combine(projectRoot, "Images"),
                Path.Combine(projectRoot, "Resources"),
                projectRoot,
                Path.Combine(appBase, "Images")
            };

            foreach (var name in filenames)
            {
                string dest = Path.Combine(appBase, name);
                if (File.Exists(dest)) continue;

                foreach (var srcDir in candidates)
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(srcDir)) continue;
                        string src = Path.Combine(srcDir, name);
                        if (File.Exists(src))
                        {
                            File.Copy(src, dest, true);
                            break;
                        }
                    }
                    catch { }
                }
            }
        }
    }
}
