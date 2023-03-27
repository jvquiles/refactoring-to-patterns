namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;

        private ProductPackage(string internetLabel)
        {
            _internetLabel = internetLabel;
        }

        public static ProductPackage CreateInternetPackage(string internetLabel)
        {
            return new ProductPackage(internetLabel);
        }

        private ProductPackage(string internetLabel, int telephoneNumber)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
        }

        public static ProductPackage CreateInternetAndTelephonePackage(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber);
        }

        private ProductPackage(string internetLabel, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _tvChannels = tvChannels;
        }

        public static ProductPackage CreateInternetAndTVPackage(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, tvChannels);
        }

        private ProductPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
        }

        public static ProductPackage CreateInternetAndTelephoneAndTVPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels);
        }

        public bool HasInternet()
        {
            return _internetLabel != null;
        }


        public bool HasVOIP()
        {
            return _telephoneNumber != null;
        }

        public bool HasTv()
        {
            return _tvChannels != null;
        }
    }
}