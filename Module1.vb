Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium
Module Module1

    Sub Main()
        Dim FirefoxOptions As New FirefoxOptions()
        FirefoxOptions.SetPreference("binary", "C:\Program Files\Mozilla Firefox\firefox.exe")
        Dim Driver As IWebDriver = New FirefoxDriver(FirefoxOptions)
        Driver.Navigate().GoToUrl("https://www.vb-net.com/")
        Dim HtmlElement As IWebElement
        Dim Id = "order"
        Try
            HtmlElement = Driver.FindElement(By.Id(Id))
            Console.WriteLine(HtmlElement.Text)
            HtmlElement.Click()
            'Dim attributeValue As String = htmlElement.GetDomAttribute("yourAttributeName")
            'Dim propertyValue As String = htmlElement.GetDomProperty("yourPropertyName")
        Catch ex As NoSuchElementException
            Console.WriteLine($"Element with ID '{Id}' not found.")
        End Try
        Console.ReadLine()
    End Sub

End Module
