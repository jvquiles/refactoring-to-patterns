namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;
        private readonly int? _mobileNumber;

        private ProductPackage(string internetLabel, int? telephoneNumber, string[] tvChannels, int? mobileNumber)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
            _mobileNumber = mobileNumber;
        }

        public static ProductPackage CreateInternetPackage(string internetLabel)
        {
            return new ProductPackage(internetLabel, null, null, null);
        }

        public static ProductPackage CreateInternetAndTelephonePackage(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber, null, null);
        }

        public static ProductPackage CreateInternetAndTVPackage(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, null, tvChannels, null);
        }

        public static ProductPackage CreateInternetAndTelephoneAndTVPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels, null);
        }

        public static ProductPackage CreateInternetAndMobilePackage(string internetLabel, int mobileNumber)
        {
            return new ProductPackage(internetLabel, null, null, mobileNumber);
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

        public bool HasMobile()
        {
            return _mobileNumber != null;
        }
    }
}