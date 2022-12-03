namespace DesignPatterns.FactoryMethod.Factory
{
    internal class AndroidMessageBox : MessageBox
    {
        public override UiButton CreateUiButton()
        {
            return new AndoridUiButton();
        }
    }
}
