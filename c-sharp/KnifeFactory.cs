using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    /// <summary>
    /// Creator
    /// </summary>
    public interface IKnifeFactory
    {
        IKnife CreateKnife(String knifeType);
    }


    /// <summary>
    /// ConcreteCreator
    /// </summary>
    public class KnifeFactory : IKnifeFactory
    {
        public IKnife CreateKnife(string knifeType)
        {
            IKnife knife = null;
            if(knifeType == "chef") {
                knife = new ChefKnife();
                return knife;
            }
            else if(knifeType == "steak")
            {
                knife = new SteakKnife();
                return knife;
            }
            return knife;

    }

}
