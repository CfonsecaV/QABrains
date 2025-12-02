using AutomationFramework.Base;
using AutomationFramework.Contexts;
using AutomationFramework.Utils;

namespace AutomationFramework.Tests
{
    public class FormSubmissionTests:BaseTest
    {
       [Test]
        public void ErrorMessageOnSubmit()
        {
            BrowserHelper.WaitUntil(_driver, d => _homeContext.IsSubmissionFormButtonEnabled());
            FormPageContext formPage = _homeContext.ClickSubmissionFormButton();
            BrowserHelper.WaitUntil(_driver, d => formPage.IsSubmitButtonEnabled());
            formPage.ClickSubmitButton();
            BrowserHelper.WaitUntil(_driver, d => formPage.IsNameErrorMessageVisible());
            Assert.Multiple(() =>
            {
                Assert.That(formPage.IsEmailErrorMessageVisible, Is.True, "Email error message missing");
                Assert.That(formPage.IsContactErrorMessageVisible, Is.True, "Contact error message missing");
                Assert.That(formPage.IsUploadErrorMessageVisible, Is.True, "Upload error message missing");
                Assert.That(formPage.IsColorErrorMessageVisible, Is.True, "Color error message missing");
                Assert.That(formPage.IsFoodErrorMessageVisible, Is.True, "Food error message missing");
                Assert.That(formPage.IsCountryErrorMessageVisible, Is.True, "Country error message missing");
            });
        }
    }
}
