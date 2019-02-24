using FirstModule;
using SecondModule;

namespace UseMultiFileAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstModuleClass.HelloWorld();
            SecondModuleClass.HelloWorld();
        }
    }
}
