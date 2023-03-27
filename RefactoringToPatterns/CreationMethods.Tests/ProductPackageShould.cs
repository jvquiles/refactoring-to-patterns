using Xunit;

namespace RefactoringToPatterns.CreationMethods.Tests
{
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var productPackage = ProductPackage.CreateInternetPackage("100MB");

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip()
        {
            var productPackage = ProductPackage.CreateInternetAndTelephonePackage("100MB", 91233788);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv()
        {
            var productPackage = ProductPackage.CreateInternetAndTVPackage("100MB", new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetVoipAndTv()
        {
            var productPackage = ProductPackage.CreateInternetAndTelephoneAndTVPackage("100MB", 91233788, new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndMobile()
        {
            var productPackage = ProductPackage.CreateInternetAndMobilePackage("100MB", 666123456);
            
            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasMobile());
        }

        [Fact]
        public void CreateWithInternetAndMobileAndTV()
        {
            var productPackage = ProductPackage.CreateInternetAndMobileAndTVPackage("100MB", 666123456, new[] {"LaLiga", "Estrenos"});
            
            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasMobile());
            Assert.True(productPackage.HasTv());
        }
    }
}