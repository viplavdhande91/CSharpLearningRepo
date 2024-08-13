namespace FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() { return GetType().Name; }

    }

    /// <summary>
    /// ConcreteProduct1
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    // if you're from Belgium, you get a better discount :)
                    case "BE":
                        return 40;
                    default:
                        return 10;
                }
            }
        }
    }

    /// <summary>
    /// ConcreteProduct2
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _couponCode;

        public CodeDiscountService(Guid couponCode)
        {
            _couponCode = couponCode;
        }

        public override int DiscountPercentage
        {
            // each code returns the same fixed percentage, but a couponCode is only 
            // valid once - include a check to so whether the couponCode's been used before
            // ... 
            get => 15;
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    /// <summary>
    /// ConcreteCreator1
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    /// <summary>
    /// ConcreteCreator2
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}