using Safety_app.Validation;
using Safety_Instructions.Validation.BaseBehaviors;
using Xamarin.Forms;

namespace Safety_Instructions.Validation.Behaviors
{
    public class NullValidationbehavior : EntryBehaviorText
    {
        public override bool Validate(TextChangedEventArgs e)
        {
            return new IsNotNullOrEmptyRule<string>().Check(e.NewTextValue);
        }
    }
}
