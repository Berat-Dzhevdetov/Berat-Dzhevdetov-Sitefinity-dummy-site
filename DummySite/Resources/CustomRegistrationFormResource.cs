using Telerik.Sitefinity.Localization;

namespace DummySite.Resources
{

    [ObjectInfo("CustomRegistrationFormResource", ResourceClassId = "CustomRegistrationFormResource", Title = "CustomRegistrationFormResource", TitlePlural = "CustomRegistrationFormResourcePlural", Description = "Is used only in registration form widget")]
    public class CustomRegistrationFormResource : Resource
    {
        [ResourceEntry("AlreadyRegistered",
            Value = "Already registered?",
            Description = "phrase: Already registered? in registration form",
            LastModified = "2022/06/08")]
        public string AlreadyRegistered
        {
            get
            {
                return this["AlreadyRegistered"];
            }
        }
    }
}