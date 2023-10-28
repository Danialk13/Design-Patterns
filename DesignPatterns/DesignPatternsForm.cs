using DesignPatterns.Behavioral.Observe;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Tools;

namespace DesignPatterns
{
    public partial class DesignPatternsForm : Form
    {
        public DesignPatternsForm()
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
            //Adaptee adaptee = new Adaptee();
            //LocalConsole.WriteLine(adaptee.SpecificRequest());

            Adaptee adaptee = new Adaptee();
            // استفاده از Adapter
            ITarget target = new Adapter(adaptee);
            target.Request();
        }

        private void btnAdapterInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
            LocalConsole.WriteLineInfo("🔷 Adapter Design Pattern:");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("✅ میزان استفاده : متوسط رو به بالا");
            LocalConsole.WriteLineInfo("✅ یک رابط موجود را به یک رابط دیگر تبدیل کنید تا کلاس‌ها یا اشیاء با یک رابط غیرمطابق به یکدیگر متصل شوند.");
            LocalConsole.WriteLineInfo("✅ آداپته کردن کد هایی با ساختار متفاوت از کد های فعلی.");
            LocalConsole.WriteLineInfo("✅ بهترین نمونه این دیزاین پترن ریپازیتوری است.");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("🔗 References:");
            LocalConsole.WriteLineInfo("⚫ https://holosen.net/adapter-design-pattern/");
            LocalConsole.WriteLineInfo("⚫ https://refactoring.guru/design-patterns/adapter/csharp/example#example-0");
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

            // استفاده از DrawingAPI برای رسم اشکال در کنسول
            DrawingAPI consoleAPI = new ConsoleDrawingAPI();

            Shape circle = new Circle(5, 10, 10, consoleAPI);
            circle.Draw();

            Shape rectangle = new Structural.Bridge.Rectangle(6, 4, 15, 20, consoleAPI);
            rectangle.Draw();

            // استفاده از DrawingAPI برای رسم اشکال در محیط گرافیکی
            DrawingAPI graphicAPI = new GraphicDrawingAPI();

            Shape circleGraphic = new Circle(8, 30, 40, graphicAPI);
            circleGraphic.Draw();

            Shape rectangleGraphic = new Structural.Bridge.Rectangle(7, 3, 50, 60, graphicAPI);
            rectangleGraphic.Draw();

            // *********************************************************************
            // Sample 2

            //Client client = new Client();

            //Abstraction abstraction;
            //// The client code should be able to work with any pre-configured
            //// abstraction-implementation combination.
            //abstraction = new Abstraction(new ConcreteImplementationA());
            //client.ClientCode(abstraction);

            //LocalConsole.WriteLine();

            //abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            //client.ClientCode(abstraction);
        }

        private void btnBridgeInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
            LocalConsole.WriteLineInfo("🔷 Bridge Design Pattern:");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("✅ میزان استفاده : متوسط");
            LocalConsole.WriteLineInfo("✅ جداسازی یک مفهوم از پیاده‌سازی آن.");
            LocalConsole.WriteLineInfo("✅ امکان مدیریت ساختار سیستم در برابر تغییرات و انعطاف ‌پذیری.");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("🔗 References:");
            LocalConsole.WriteLineInfo("⚫ https://holosen.net/bridge-design-pattern/");
            LocalConsole.WriteLineInfo("⚫ https://refactoring.guru/design-patterns/bridge/csharp/example");
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
            // Sample 1

            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            // *********************************************************************
            // Sample 2

            //BankAccount account = new BankAccount();

            //IObserver2 logger1 = new TransactionLogger("Logger 1");
            //IObserver2 logger2 = new TransactionLogger("Logger 2");

            //account.AddObserver(logger1);
            //account.AddObserver(logger2);

            //account.AddTransaction(100);
            //account.AddTransaction(-50);

            //account.RemoveObserver(logger1);

            //account.AddTransaction(200);
        }

        private void btnObserveInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
            LocalConsole.WriteLineInfo("🔷 Observe Design Pattern:");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("✅ میزان استفاده : زیاد");
            LocalConsole.WriteLineInfo("✅ وقتی یک شیء حالت خود را تغییر می دهد، همه وابستگان آن به طور خودکار مطلع و به روز می شوند.");
            LocalConsole.WriteLineInfo("✅ مناسب برای لاگ کردن یا مواقعی که میخواهیم با تغییرات در آبجکت خود یک اتفاقاتی رخ بدهد.");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("🔗 References:");
            LocalConsole.WriteLineInfo("⚫ https://holosen.net/observer-design-pattern/");
            LocalConsole.WriteLineInfo("⚫ https://refactoring.guru/design-patterns/observer/csharp/example#example-0");
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            // Sample 1

            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            LocalConsole.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            VisitorClient.ClientCode(components, visitor1);

            LocalConsole.WriteLine();

            LocalConsole.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            VisitorClient.ClientCode(components, visitor2);

            // *********************************************************************
            // Sample 2

            //List<Behavioral.Visitor.BankAccount> accounts = new List<Behavioral.Visitor.BankAccount>
            //{
            //    new SavingsAccount(),
            //    new CheckingAccount(),
            //    new InvestmentAccount()
            //};

            //TaxVisitor taxVisitor = new TaxVisitor();

            //foreach (var account in accounts)
            //{
            //    account.Accept(taxVisitor);
            //}
        }

        private void btnVisitorInfo_Click(object sender, EventArgs e)
        {
            LocalConsole.ClearInfo();
            LocalConsole.WriteLineInfo("🔷 Visitor Design Pattern:");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("✅ میزان استفاده : کم");
            LocalConsole.WriteLineInfo("✅ این الگو به شما امکان می دهد بدون تغییر کلاس عناصری که بر روی آنها کار می کند ، یک عملیات جدید تعریف کنید.");
            LocalConsole.WriteLineInfo("✅ برای اعمال یک عملکرد خاص بر روی یک مجموعه از اشیاء متفاوت استفاده می‌شود بدون اینکه به کلاس‌های این اشیاء دسترسی داشته باشد یا بدون اینکه این اشیاء را تغییر دهد.");
            LocalConsole.WriteLineInfo("");
            LocalConsole.WriteLineInfo("🔗 References:");
            LocalConsole.WriteLineInfo("⚫ https://holosen.net/visitor-design-pattern/");
            LocalConsole.WriteLineInfo("⚫ https://refactoring.guru/design-patterns/visitor/csharp/example#example-0");
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