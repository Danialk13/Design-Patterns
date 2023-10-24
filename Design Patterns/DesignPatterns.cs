using Design_Patterns.Bridge;
using Design_Patterns.Bridge2;
using Design_Patterns.Tools;

namespace Design_Patterns
{
    public partial class DesignPatterns : Form
    {
        public DesignPatterns()
        {
            InitializeComponent();
        }

        #region Creational

        private void gbStructural_Enter(object sender, EventArgs e)
        {

        }

        private void btnFactoryMethod_Click(object sender, EventArgs e)
        {

        }

        private void btnFactoryMethodInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {

        }

        private void btnBuilderInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {

        }

        private void btnSingletonInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAbstractFactory_Click(object sender, EventArgs e)
        {

        }

        private void btnAbstractFactoryInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnPrototype_Click(object sender, EventArgs e)
        {

        }

        private void btnPrototypeInfo_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Structural

        private void btnAdapter_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdapterInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComposite_Click(object sender, EventArgs e)
        {

        }

        private void btnCompositeInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnFacade_Click(object sender, EventArgs e)
        {

        }

        private void btnFacadeInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnProxy_Click(object sender, EventArgs e)
        {

        }

        private void btnProxyInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            // Sample 1

            //// استفاده از DrawingAPI برای رسم اشکال در کنسول
            //DrawingAPI consoleAPI = new ConsoleDrawingAPI();

            //Shape circle = new Circle(5, 10, 10, consoleAPI);
            //circle.Draw();

            //Shape rectangle = new Bridge.Rectangle(6, 4, 15, 20, consoleAPI);
            //rectangle.Draw();

            //// استفاده از DrawingAPI برای رسم اشکال در محیط گرافیکی
            //DrawingAPI graphicAPI = new GraphicDrawingAPI();

            //Shape circleGraphic = new Circle(8, 30, 40, graphicAPI);
            //circleGraphic.Draw();

            //Shape rectangleGraphic = new Bridge.Rectangle(7, 3, 50, 60, graphicAPI);
            //rectangleGraphic.Draw();

            // *********************************************************************
            // Sample 2


            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            LocalConsole.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }

        private void btnBridgeInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
            LocalConsole.WriteLineInfo("Bridge Design Pattern:");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("✅ میزان استفاده : متوسط");
            LocalConsole.WriteLineInfo("✅ جداسازی یک مفهوم از پیاده‌سازی آن");
            LocalConsole.WriteLineInfo("✅ امکان مدیریت ساختار سیستم در برابر تغییرات و انعطاف ‌پذیری");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("References:");
            LocalConsole.WriteLineInfo("https://holosen.net/bridge-design-pattern/");
            LocalConsole.WriteLineInfo("https://refactoring.guru/design-patterns/bridge/csharp/example#:~:text=Bridge%20is%20a%20structural%20design,the%20second%20hierarchy%20(Implementation).");
        }

        private void btnDecorator_Click(object sender, EventArgs e)
        {

        }

        private void btnDecoratorInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnFlyweight_Click(object sender, EventArgs e)
        {

        }

        private void btnFlyweightInfo_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Behavioral

        private void btnChainOfResponsibility_Click(object sender, EventArgs e)
        {

        }

        private void btnChainOfResponsibilityInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnMemento_Click(object sender, EventArgs e)
        {

        }

        private void btnMementoInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnTemplateMethod_Click(object sender, EventArgs e)
        {

        }

        private void btnTemplateMethodInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCommand_Click(object sender, EventArgs e)
        {

        }

        private void btnCommandInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnObserve_Click(object sender, EventArgs e)
        {

        }

        private void btnObserveInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitorInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnIterator_Click(object sender, EventArgs e)
        {

        }

        private void btnIteratorInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnState_Click(object sender, EventArgs e)
        {

        }

        private void btnStateInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnMediator_Click(object sender, EventArgs e)
        {

        }

        private void btnMediatorInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnStrategy_Click(object sender, EventArgs e)
        {

        }

        private void btnStrategyInfo_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            LocalConsole.Clear();
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
        }

        private void DesignPatterns_Load(object sender, EventArgs e)
        {
            LocalConsole.Clear();
            LocalConsole.ClearInfo();
        }
    }
}