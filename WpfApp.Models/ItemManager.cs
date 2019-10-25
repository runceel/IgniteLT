using System.Collections.ObjectModel;
using System.Linq;

namespace WpfApp.Models
{
    public class ItemManager
    {
        public ObservableCollection<Category> Categories { get; }

        public ItemManager()
        {
            Categories = new ObservableCollection<Category>(new[]
            {
                new Category("Animals")
                {
                    Items =
                    {
                        new Item("Dog", "🐶"),
                        new Item("Cat", "🐈"),
                        new Item("Sheep", "🐑"),
                    },
                },
                new Category("Japanese foods")
                {
                    Items =
                    {
                        new Item("Sushi", "🍣"),
                        new Item("Tenpura", "🍤"),
                        new Item("Rice ball", "🍙"),
                    },
                },
            });
        }

        public Category? FindCategoryById(string id) => Categories.FirstOrDefault(x => x.Id == id);

        public void AddFood(Category targetCategory, Item food)
        {
            targetCategory.Items.Add(food);
        }
    }
}
