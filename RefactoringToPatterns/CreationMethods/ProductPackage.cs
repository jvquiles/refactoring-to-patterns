namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;

        private ProductPackage(string internetLabel, int? telephoneNumber, string[] tvChannels)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
        }

        public static ProductPackage CreateInternetPackage(string internetLabel)
        {
            return new ProductPackage(internetLabel, null, null);
        }

        public static ProductPackage CreateInternetAndTelephonePackage(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber, null);
        }

        public static ProductPackage CreateInternetAndTVPackage(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, null, tvChannels);
        }

        public static ProductPackage CreateInternetAndTelephoneAndTVPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels);
        }

        public static ProductPackage CreateInternetAndMobilePackage()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}