using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Attributes;
using Umbraco.Forms.Core.Enums;

namespace FormsUpgradeTest.CustomFieldType
{
    public class CountrySelect : FieldType
    {
        private static readonly List<Setting> SettingsList = new List<Setting>
        {
            new LabelSettingAttribute("Enter value for country label"),
        };

        public CountrySelect()
        {
            this.Id = new Guid("38b7ea54-e471-4bc8-a976-63a73d943bec");
            this.Name = "Country DropdownList";
            this.Description = "Render country dropdown list.";
            this.DataType = FieldDataType.String;
            this.Icon = "icon-globe";
            this.FieldTypeViewName = "FieldType.CountrySelect.cshtml";
        }

        public override Dictionary<string, Setting> Settings() => SettingsList.ToDictionary(l => l.Alias, l => l);
    }
}
