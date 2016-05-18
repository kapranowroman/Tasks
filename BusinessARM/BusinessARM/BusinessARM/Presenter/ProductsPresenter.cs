using BusinessARM.DAO;
using BusinessARM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessARM.Presenter
{
    public class ProductsPresenter
    {
        private productDAO productDAO;
        public List<Product> cached;
        private Products view;
        private FormState state;

        public ProductsPresenter(Products view)
        {
            productDAO = new productDAO();
            cached = new List<Product>();
            this.view = view;
            this.state = FormState.UPDATE_OLD;
        }

        public void loadProducts()
        {
            cached = productDAO.getList();
            view.ClearFields();
            view.displayProducts(cached);
            state = FormState.UPDATE_OLD;

        
        }
        public void filterWith(String part)
        {
            state = FormState.UPDATE_OLD;
            part = part.ToLower();
            List<Product> result = new List<Product>();
            foreach (Product p in cached)
            {
                if (p.description.ToLower().Contains(part))
                {
                    result.Add(p);
                }
            }
            view.ClearFields();
            view.displayProducts(result);
        
        }
        public void beginAdd()
        {
            state = FormState.ADD_NEW;
            view.ClearFields();
        }
        public void cancelAdd()
        {
            state = FormState.UPDATE_OLD;
        }
        public void save(
        
            Product selected,
            Decimal money,
            string description,
            Decimal weight,
            int quantity,
            Guid productGroupID,
            Units Unit            
        )
        {
            if (state == FormState.ADD_NEW)
            {


                Product current = new Product();
                //current = new Product();
                current.id = Guid.NewGuid();
                current.money = money;
                current.description = description;
                current.weight = weight;
                current.quantity = quantity;
                current.productGroupID = productGroupID;
                current.Unit = Unit;

                


                if (current.Unit.Equals(Units.EMPTY))
                {
                    view.notify ("Заполните Единицу измерения");
                    state = FormState.UPDATE_OLD;
                    return;
                }

                if (current.money < 0)
                {
                    view.notify("Цена не может быть меньше 0");
                    state = FormState.UPDATE_OLD;
                    return;
                }

                if (current.weight <= 0)
                {
                    view.notify("Введите вес больше 0");
                    state = FormState.UPDATE_OLD;
                    return;
                }


                if (productDAO.add(current))
                {
                    view.notify("Успешно добавлено");
                }
                state = FormState.UPDATE_OLD;

            }
            else
            {
                if (selected == null)
                {
                    view.notify("Выберите товар для изменения");
                    return;
                }

                selected.money = money;
                selected.description = description;
                selected.weight = weight;
                selected.quantity = quantity;
                selected.productGroupID = productGroupID;
                selected.Unit = Unit;


               

                if (selected.Unit.Equals(Units.EMPTY))
                {
                    view.notify("Заполните Единицу измерения");
                    return;
                }

                if (selected.money < 0)
                {
                    view.notify("Цена не может быть меньше 0");
                    return;
                }

                if (selected.weight <= 0)
                {
                    view.notify("Введите вес больше 0");
                    return;
                }

                if (productDAO.update(selected))
                {
                    view.notify("Успешно изменено");
                }

            }
    }
        public void delete(Product selected)
        {
            if (selected == null)
            {
                view.notify("Выберите товар для изменения");
                return;
            }
            if (productDAO.delete(selected))
            {
                view.notify("Успешно изменено");
            }
        }

    }
}
