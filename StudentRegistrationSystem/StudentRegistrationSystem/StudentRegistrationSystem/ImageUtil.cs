using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    internal static class ImageUtil
    {
        public static void LoadImage(PictureBox pb, string filename)
        {
            if (pb == null || string.IsNullOrWhiteSpace(filename)) return;
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string[] candidates = new string[] {
                    Path.Combine(baseDir, filename),
                    Path.Combine(Environment.CurrentDirectory, filename),
                    Path.Combine(baseDir, "Resources", filename),
                    Path.Combine(baseDir, "Images", filename),
                };

                foreach (var path in candidates)
                {
                    if (File.Exists(path))
                    {
                        pb.Image = Image.FromFile(path);
                        return;
                    }
                }

                var asm = Assembly.GetExecutingAssembly();
                var names = asm.GetManifestResourceNames();
                foreach (var res in names)
                {
                    if (res.EndsWith(filename, StringComparison.OrdinalIgnoreCase))
                    {
                        using (var s = asm.GetManifestResourceStream(res))
                        {
                            if (s != null)
                            {
                                using (var img = Image.FromStream(s))
                                {
                                    pb.Image = new Bitmap(img);
                                }
                                return;
                            }
                        }
                    }
                }

                var resType = asm.GetType(asm.GetName().Name + ".Properties.Resources");
                if (resType != null)
                {
                    var propName = Path.GetFileNameWithoutExtension(filename);
                    var prop = resType.GetProperty(propName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    if (prop != null)
                    {
                        var val = prop.GetValue(null, null);
                        if (val is Image imgVal)
                        {
                            pb.Image = new Bitmap(imgVal);
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
}
