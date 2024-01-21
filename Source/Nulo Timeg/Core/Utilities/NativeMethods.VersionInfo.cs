namespace Nulo.Core.Utilities {

    internal static partial class NativeMethods {

        public static string GetCopyright() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.LegalCopyright;
            } catch {
                return string.Empty;
            }
        }

        public static string GetSmallVersion() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return $"{info.ProductMajorPart}.{info.ProductMinorPart}";
            } catch {
                return string.Empty;
            }
        }

        public static string GetProductName() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.ProductName.Replace(" ®", "®");
            } catch {
                return string.Empty;
            }
        }

        public static string GetIdProduct() {
            return "{6350f1a1-d575-424f-a53c-193ecfb58809}";
        }
    }
}