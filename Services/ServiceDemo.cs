using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    //public class CategoryService : ICategoryService
    //{
    //    private IRepository<Categories> repository = new GenericRepository<Categories>();


    //    public IResult Create(Categories instance)
    //    {
    //        if (instance == null)
    //        {
    //            throw new ArgumentNullException();
    //        }

    //        IResult result = new Result(false);
    //        try
    //        {
    //            this.repository.Create(instance);
    //            result.Success = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            result.Exception = ex;
    //        }
    //        return result;
    //    }

    //    public IResult Update(Categories instance)
    //    {
    //        if (instance == null)
    //        {
    //            throw new ArgumentNullException();
    //        }

    //        IResult result = new Result(false);
    //        try
    //        {
    //            this.repository.Update(instance);
    //            result.Success = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            result.Exception = ex;
    //        }
    //        return result;
    //    }

    //    public IResult Delete(int categoryID)
    //    {
    //        IResult result = new Result(false);

    //        if (!this.IsExists(categoryID))
    //        {
    //            result.Message = "找不到資料";
    //        }

    //        try
    //        {
    //            var instance = this.GetByID(categoryID);
    //            this.repository.Delete(instance);
    //            result.Success = true;
    //        }
    //        catch (Exception ex)
    //        {
    //            result.Exception = ex;
    //        }
    //        return result;
    //    }

    //    public bool IsExists(int categoryID)
    //    {
    //        return this.repository.GetAll().Any(x => x.CategoryID == categoryID);
    //    }

    //    public Categories GetByID(int categoryID)
    //    {
    //        return this.repository.Get(x => x.CategoryID == categoryID);
    //    }

    //    public IEnumerable<Categories> GetAll()
    //    {
    //        return this.repository.GetAll();
    //    }
    //}

public sealed class ServiceLocatorDependencyResolver: IDependencyResolver, IServiceLocator
   2:     {
   3:         #region Public constructor
   4:         public ServiceLocatorDependencyResolver(IServiceLocator serviceLocator)
   5:         {
   6:             if (serviceLocator == null)
   7:             {
   8:                 throw (new ArgumentNullException("serviceLocator"));
   9:             }
  10:  
  11:             this.ServiceLocator = serviceLocator;
  12:         }
  13:         #endregion
  14:  
  15:         #region Public properties
  16:         public IServiceLocator ServiceLocator
  17:         {
  18:             get;
  19:             private set;
  20:         }
  21:         #endregion
  22:  
  23:         #region Public IDependencyResolver methods
  24:         public Object GetService(Type serviceType)
  25:         {
  26:             try
  27:             {
  28:                 return (this.ServiceLocator.GetService(serviceType));
  29:             }
  30:             catch
  31:             {
  32:                 return (null);
  33:             }
  34:         }
  35:  
  36:         public IEnumerable<Object> GetServices(Type serviceType)
  37:         {
  38:             try
  39:             {
  40:                 return (this.ServiceLocator.GetAllInstances(serviceType));
  41:             }
  42:             catch
  43:             {
  44:                 return (null);
  45:             }
  46:         }
  47:         #endregion
  48:  
  49:         #region Public IServiceLocator methods
  50:         public IEnumerable<TService> GetAllInstances<TService>()
  51:         {
  52:             return (this.ServiceLocator.GetAllInstances<TService>());
  53:         }
  54:  
  55:         public IEnumerable<Object> GetAllInstances(Type serviceType)
  56:         {
  57:             return (this.ServiceLocator.GetAllInstances(serviceType));
  58:         }
  59:  
  60:         public TService GetInstance<TService>(String key)
  61:         {
  62:             return (this.ServiceLocator.GetInstance<TService>(key));
  63:         }
  64:  
  65:         public TService GetInstance<TService>()
  66:         {
  67:             return (this.ServiceLocator.GetInstance<TService>());
  68:         }
  69:  
  70:         public Object GetInstance(Type serviceType, String key)
  71:         {
  72:             return (this.ServiceLocator.GetInstance(serviceType, key));
  73:         }
  74:  
  75:         public Object GetInstance(Type serviceType)
  76:         {
  77:             return (this.ServiceLocator.GetInstance(serviceType));
  78:         }
  79:         #endregion
  80:     }
}
