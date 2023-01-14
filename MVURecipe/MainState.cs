using System;
namespace MVURecipe
{
    public class MainState : BindingObject
    {
        public string Forename
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }
        public string Surname
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        internal void Reset()
        {
            Forename = "";
            Surname = "";
        }
    }
}

