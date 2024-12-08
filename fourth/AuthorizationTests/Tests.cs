using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AuthorizationTests
{
    public class Tests
    {

        private IWebDriver driver;

        private readonly By _signInBtn = By.XPath("//span[text()='Войти']");
        private readonly By _differentWayBtn = By.XPath("//span[text()='Другим способом']");
        private readonly By _continueBtn = By.XPath("//span[text()='Продолжить']");
        private readonly By _inputMailField = By.XPath("//input[@name='username']");
        private readonly By _inputPasswordField = By.XPath("//input[@name='password']");
        private readonly By _loginBtn = By.XPath("//button[@data-name='ContinueAuthBtn']//span[text()='Войти']");

        private const string _LOGIN = "pobirchev2006@mail.ru";
        private const string _PASSWORD = "heythereimdoinwell";
        private const string _TOTAL_AREA = "15";
        private const string _ORDER_TITLE = "qwertyuiopasdfghjkl";
        private const string _ORDER_DESCRIPTION = "Hey there, I am testing Cian with Selenium right now! Have a nice day =)";
        private const string _ORDER_PRICE = "20000000";
        private const string _PRIMARY_PHONE = "9110943172";

        private readonly By _newOrderBtn = By.XPath("//span[@class='_25d45facb5--text--V2xLI']");
        private readonly By _sellBtn = By.XPath("//span[text()='Продажа']");
        private readonly By _sellBoxBtn = By.XPath("//span[text()='Гараж']");
        private readonly By _createOrderBtn = By.XPath("//span[text()='Создать']");
        private readonly By _nextBtn = By.XPath("//span[text()='Дальше']");
        private readonly By _typeOfSpaceBtn = By.XPath("//span[text()='Гараж']");
        private readonly By _inputTotalAreaField = By.XPath("//input[@name='totalArea']");
        private readonly By _spaceStatusBtn = By.XPath("//span[text()='Собственность']");
        private readonly By _spaceCommunicationsBtn = By.XPath("//span[text()='Вода']");
        private readonly By _spaceParkBtn = By.XPath("//span[text()='Наземная']");
        private readonly By _inputOrderTitleField = By.XPath("//input[@name='title']");
        private readonly By _inputOrderDescriptionField = By.XPath("//textarea[@name='description']");
        private readonly By _inputOrderPrice = By.XPath("//input[@name='price']");
        private readonly By _inputOrderPhoneNumber = By.XPath("//input[@name='primaryPhone']");

        [SetUp]
        public void Setup()
        {

            System.Environment.SetEnvironmentVariable("chromedriver", @"C:\Users\ryche\Desktop\chromedriver.exe");

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestCreateOrder()
        {
            IWebElement webElement = driver.FindElement(_newOrderBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_sellBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_sellBoxBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_createOrderBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_nextBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_typeOfSpaceBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputTotalAreaField);
            webElement.SendKeys(_TOTAL_AREA);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_spaceStatusBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_nextBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_spaceCommunicationsBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_spaceParkBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_nextBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputOrderTitleField);
            webElement.SendKeys(_ORDER_TITLE);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputOrderDescriptionField);
            webElement.SendKeys(_ORDER_DESCRIPTION);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_nextBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputOrderPrice);
            webElement.SendKeys(_ORDER_PRICE);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputOrderPhoneNumber);
            webElement.SendKeys(_PRIMARY_PHONE);
            Thread.Sleep(1000);
        }

        [Test]
        public void TestSignIn()
        {

            IWebElement webElement = driver.FindElement(_signInBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_differentWayBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputMailField);
            webElement.SendKeys(_LOGIN);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_continueBtn);
            webElement.Click();
            Thread.Sleep(1000);

            webElement = driver.FindElement(_inputPasswordField);
            webElement.SendKeys(_PASSWORD);
            Thread.Sleep(1000);

            webElement = driver.FindElement(_loginBtn);
            webElement.Click();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {

            Thread.Sleep(5000);
            driver.Close();
        }
    }
}