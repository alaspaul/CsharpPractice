using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelValidationPractice.Models;

namespace ModelValidationPractice.CustomModelBinders
{
    public class PersonModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            Person person = new Person();
            //FirstName and LastName
            if(bindingContext.ValueProvider.GetValue("FirstName").Length > 0)
            {
                person.Name = bindingContext.ValueProvider.GetValue("FirstName").FirstOrDefault();

                if (bindingContext.ValueProvider.GetValue("LastName").Length > 0)
                {
                    person.Name += " " + bindingContext.ValueProvider.GetValue("LastName").FirstOrDefault();
                }

            }

            if (bindingContext.ValueProvider.GetValue("Email").Length > 0)
            {
                person.Email = bindingContext.ValueProvider.GetValue("Email").FirstOrDefault();
            }

            if (bindingContext.ValueProvider.GetValue("Phone").Length > 0)
            {
                person.Phone = bindingContext.ValueProvider.GetValue("Phone").FirstOrDefault();
            }

            if (bindingContext.ValueProvider.GetValue("Password").Length > 0)
            {
                person.Password = bindingContext.ValueProvider.GetValue("Password").FirstOrDefault();
            }

            if (bindingContext.ValueProvider.GetValue("ConfirmPassword").Length > 0)
            {
                person.ConfirmPassword = bindingContext.ValueProvider.GetValue("ConfirmPassword").FirstOrDefault();
            }

            if (bindingContext.ValueProvider.GetValue("Price").Length > 0)
            {
                person.Price = Convert.ToDouble(bindingContext.ValueProvider.GetValue("Price").FirstOrDefault());
            }

            if (bindingContext.ValueProvider.GetValue("Age").Length > 0)
            {
                person.Age = Convert.ToInt32(bindingContext.ValueProvider.GetValue("Age").FirstOrDefault());
            }


            bindingContext.Result = ModelBindingResult.Success(person);
            return Task.CompletedTask;
        }
    }
}
