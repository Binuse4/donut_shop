using DonutShop.Models;

namespace DonutShop.Services
{
    public class OrderState
    {
        public bool ShowingCustomeDialog { get; private set; }
        public Donut? ConfiguringDonut { get; private set; }
        public Order Order { get; private set; } = new Order();

        public event Action? OnChange;
        public int ItemCount => Order.Donuts.Count;

        public void ShowCustomizededDonutDialog(DonutSpecial special)
        {
            ConfiguringDonut = new Donut()
            {
                Special = special,
                SpecialId = special.Id,
                Quantity = Donut.InitialtNumber,
                Decorations = new List<DonutDecoration>(),
            };

            ShowingCustomeDialog = true;
            NotifyStateChanged();
        }

        public void CancelCustomizededDonutDialog()
        {
            ConfiguringDonut = null;

            ShowingCustomeDialog = false;
            NotifyStateChanged();
        }

        public void ConfirmCustomizededDonutDialog()
        {
            Order.Donuts.Add(ConfiguringDonut);
            ConfiguringDonut = null;

            ShowingCustomeDialog = false;
            NotifyStateChanged();
        }

        public void RemoveCustomizedDonut(Donut donut)
        {
            Order.Donuts.Remove(donut);
            NotifyStateChanged();
        }

        public void ResetOrder()
        {
            Order = new Order();
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
