using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_Shop_core.Data.Models
{
    public class ArticlesRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly AppDBContent context;
        public ArticlesRepository(AppDBContent context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Articles
        public IQueryable<RegisteViewModel> GetArticles()
        {
            return context.RegisteViewModel.OrderBy(x => x.Login);
        }

        //найти определенную запись по id
        public RegisteViewModel GetById(Guid id)
        {
            return context.RegisteViewModel.Single(x => x.id == id);
        }

        public bool GetByLogin(string Login)
        {
            var log = context.RegisteViewModel.Where(p => EF.Functions.Like(p.Login, Login));
            if(log == null)
            {
                return true;
            }
            return false;
        }

        public bool GetByEmail(string Email)
        {
            var email = context.RegisteViewModel.Where(p => EF.Functions.Like(p.Email, Email));
            if (email == null)
            {
                return true;
            }
            return false;
        }

        //сохранить новую либо обновить существующую запись в БД
        public Guid SaveArticle(RegisteViewModel entity)
        {
            if (entity.id == default)
            {
                context.Entry(entity).State = EntityState.Added;
                context.RegisteViewModel.Add(entity);

            }
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.id;
        }

        //удалить существующую запись
        public void DeleteArticle(RegisteViewModel entity)
        {
            context.RegisteViewModel.Remove(entity);
            context.SaveChanges();
        }
    }
}
