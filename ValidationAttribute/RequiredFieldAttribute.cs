using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttribute
{
    public class RequiredFieldAttribute : Attribute
    {

    }

    public static class ValidationTool
    {
        public static bool Validate(object entity)
        {
            Type type = entity.GetType();
            PropertyInfo[] ValidationFields = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo field in ValidationFields)
            {
                bool isRequired = field.GetCustomAttributes(typeof(RequiredFieldAttribute), true).Any();
                if (isRequired)
                {
                    string fieldValue = field.GetValue(entity).ToString();
                    if (string.IsNullOrEmpty(fieldValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
