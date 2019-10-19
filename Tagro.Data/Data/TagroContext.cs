﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String:      "Data Source=DESKTOP-BV8O50V;Initial Catalog=TEST;Integrated Security=True;Application Name=EntityFramework Reverse POCO Generator"
// ------------------------------------------------------------------------------------------------
// Database Edition        : Enterprise Edition (64-bit)
// Database Engine Edition : Enterprise
// Database Version        : 14.0.2027.2

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Tagro.Data.Data
{
    using System.Linq;

    #region Unit of work

    public interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        System.Data.Entity.DbSet<ImageNew> ImageNews { get; set; } // ImageNews
        System.Data.Entity.DbSet<Report> Reports { get; set; } // Report

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class MyDbContext : System.Data.Entity.DbContext, IMyDbContext
    {
        public System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        public System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        public System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        public System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<ImageNew> ImageNews { get; set; } // ImageNews
        public System.Data.Entity.DbSet<Report> Reports { get; set; } // Report

        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=TagroContext")
        {
        }

        public MyDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public MyDbContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ImageNewConfiguration());
            modelBuilder.Configurations.Add(new ReportConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ImageNewConfiguration(schema));
            modelBuilder.Configurations.Add(new ReportConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region Database context factory

    public class MyDbContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<MyDbContext>
    {
        public MyDbContext Create()
        {
            return new MyDbContext();
        }
    }

    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeMyDbContext : IMyDbContext
    {
        public System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; }
        public System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; }
        public System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<ImageNew> ImageNews { get; set; }
        public System.Data.Entity.DbSet<Report> Reports { get; set; }

        public FakeMyDbContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            AspNetRoles = new FakeDbSet<AspNetRole>("Id");
            AspNetUsers = new FakeDbSet<AspNetUser>("Id");
            AspNetUserClaims = new FakeDbSet<AspNetUserClaim>("Id");
            AspNetUserLogins = new FakeDbSet<AspNetUserLogin>("LoginProvider", "ProviderKey", "UserId");
            Categories = new FakeDbSet<Category>("Id");
            ImageNews = new FakeDbSet<ImageNew>("Id");
            Reports = new FakeDbSet<Report>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            var m = expression as System.Linq.Expressions.MethodCallExpression;
            if (m != null)
            {
                var resultType = m.Method.ReturnType; // it shoud be IQueryable<T>
                var tElement = resultType.GetGenericArguments()[0];
                var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(tElement);
                return (IQueryable) System.Activator.CreateInstance(queryType, expression);
            }
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(typeof(TElement));
            return (IQueryable<TElement>)System.Activator.CreateInstance(queryType, expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // AspNetRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetRole
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public string Name { get; set; } // Name (length: 256)

        // Reverse navigation

        /// <summary>
        /// Child AspNetUsers (Many-to-Many) mapped by table [AspNetUserRoles]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUser> AspNetUsers { get; set; } // Many to many mapping

        public AspNetRole()
        {
            AspNetUsers = new System.Collections.Generic.List<AspNetUser>();
        }
    }

    // AspNetUsers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUser
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public string Email { get; set; } // Email (length: 256)
        public bool EmailConfirmed { get; set; } // EmailConfirmed
        public string PasswordHash { get; set; } // PasswordHash
        public string SecurityStamp { get; set; } // SecurityStamp
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
        public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
        public System.DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
        public bool LockoutEnabled { get; set; } // LockoutEnabled
        public int AccessFailedCount { get; set; } // AccessFailedCount
        public string UserName { get; set; } // UserName (length: 256)

        // Reverse navigation

        /// <summary>
        /// Child AspNetRoles (Many-to-Many) mapped by table [AspNetUserRoles]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetRole> AspNetRoles { get; set; } // Many to many mapping
        /// <summary>
        /// Child AspNetUserClaims where [AspNetUserClaims].[UserId] point to this entity (FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims.FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        /// <summary>
        /// Child AspNetUserLogins where [AspNetUserLogins].[UserId] point to this entity (FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins.FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
        /// <summary>
        /// Child Reports where [Report].[UserId] point to this entity (FK_News_AspNetUsers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Report> Reports { get; set; } // Report.FK_News_AspNetUsers

        public AspNetUser()
        {
            AspNetUserClaims = new System.Collections.Generic.List<AspNetUserClaim>();
            AspNetUserLogins = new System.Collections.Generic.List<AspNetUserLogin>();
            Reports = new System.Collections.Generic.List<Report>();
            AspNetRoles = new System.Collections.Generic.List<AspNetRole>();
        }
    }

    // AspNetUserClaims
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUserClaim
    {
        public int Id { get; set; } // Id (Primary key)
        public string UserId { get; set; } // UserId (length: 128)
        public string ClaimType { get; set; } // ClaimType
        public string ClaimValue { get; set; } // ClaimValue

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [AspNetUserClaims].([UserId]) (FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
    }

    // AspNetUserLogins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUserLogin
    {
        public string LoginProvider { get; set; } // LoginProvider (Primary key) (length: 128)
        public string ProviderKey { get; set; } // ProviderKey (Primary key) (length: 128)
        public string UserId { get; set; } // UserId (Primary key) (length: 128)

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [AspNetUserLogins].([UserId]) (FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
    }

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Category
    {
        public int Id { get; set; } // Id (Primary key)
        public int? ParentId { get; set; } // ParentId
        public System.DateTime? CreatedDate { get; set; } // CreatedDate
        public System.DateTime? UpdatedDate { get; set; } // UpdatedDate
        public byte? Status { get; set; } // Status
        public string Name { get; set; } // Name (length: 150)
        public string Description { get; set; } // Description (length: 250)

        // Reverse navigation

        /// <summary>
        /// Child Categories where [Category].[ParentId] point to this entity (FK_Category_Category)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Category> Categories { get; set; } // Category.FK_Category_Category
        /// <summary>
        /// Child Reports where [Report].[CategoryId] point to this entity (FK_News_Category)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Report> Reports { get; set; } // Report.FK_News_Category

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [Category].([ParentId]) (FK_Category_Category)
        /// </summary>
        public virtual Category Parent { get; set; } // FK_Category_Category

        public Category()
        {
            Categories = new System.Collections.Generic.List<Category>();
            Reports = new System.Collections.Generic.List<Report>();
        }
    }

    // ImageNews
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class ImageNew
    {
        public int Id { get; set; } // Id (Primary key)
        public int? NewsId { get; set; } // NewsId
        public string Path { get; set; } // Path (length: 200)

        // Foreign keys

        /// <summary>
        /// Parent Report pointed by [ImageNews].([NewsId]) (FK_ImageNews_News)
        /// </summary>
        public virtual Report Report { get; set; } // FK_ImageNews_News
    }

    // Report
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Report
    {
        public int Id { get; set; } // Id (Primary key)
        public byte? Status { get; set; } // Status
        public System.DateTime? UpdatedDate { get; set; } // UpdatedDate
        public System.DateTime? CreatedDate { get; set; } // CreatedDate
        public string Title { get; set; } // Title (length: 150)
        public string Body { get; set; } // Body
        public string Code { get; set; } // Code (length: 50)
        public int? ImageId { get; set; } // ImageId
        public int? CategoryId { get; set; } // CategoryId
        public string UserId { get; set; } // UserId (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child ImageNews where [ImageNews].[NewsId] point to this entity (FK_ImageNews_News)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ImageNew> ImageNews { get; set; } // ImageNews.FK_ImageNews_News

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [Report].([UserId]) (FK_News_AspNetUsers)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_News_AspNetUsers

        /// <summary>
        /// Parent Category pointed by [Report].([CategoryId]) (FK_News_Category)
        /// </summary>
        public virtual Category Category { get; set; } // FK_News_Category

        public Report()
        {
            ImageNews = new System.Collections.Generic.List<ImageNew>();
        }
    }

    #endregion

    #region POCO Configuration

    // AspNetRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetRoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetRole>
    {
        public AspNetRoleConfiguration()
            : this("dbo")
        {
        }

        public AspNetRoleConfiguration(string schema)
        {
            ToTable("AspNetRoles", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            HasMany(t => t.AspNetUsers).WithMany(t => t.AspNetRoles).Map(m =>
            {
                m.ToTable("AspNetUserRoles", "dbo");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }

    // AspNetUsers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUser>
    {
        public AspNetUserConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserConfiguration(string schema)
        {
            ToTable("AspNetUsers", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.EmailConfirmed).HasColumnName(@"EmailConfirmed").HasColumnType("bit").IsRequired();
            Property(x => x.PasswordHash).HasColumnName(@"PasswordHash").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.SecurityStamp).HasColumnName(@"SecurityStamp").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PhoneNumberConfirmed).HasColumnName(@"PhoneNumberConfirmed").HasColumnType("bit").IsRequired();
            Property(x => x.TwoFactorEnabled).HasColumnName(@"TwoFactorEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.LockoutEndDateUtc).HasColumnName(@"LockoutEndDateUtc").HasColumnType("datetime").IsOptional();
            Property(x => x.LockoutEnabled).HasColumnName(@"LockoutEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.AccessFailedCount).HasColumnName(@"AccessFailedCount").HasColumnType("int").IsRequired();
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
        }
    }

    // AspNetUserClaims
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUserClaimConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUserClaim>
    {
        public AspNetUserClaimConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserClaimConfiguration(string schema)
        {
            ToTable("AspNetUserClaims", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.ClaimType).HasColumnName(@"ClaimType").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ClaimValue).HasColumnName(@"ClaimValue").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserClaims).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        }
    }

    // AspNetUserLogins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class AspNetUserLoginConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUserLogin>
    {
        public AspNetUserLoginConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserLoginConfiguration(string schema)
        {
            ToTable("AspNetUserLogins", schema);
            HasKey(x => new { x.LoginProvider, x.ProviderKey, x.UserId });

            Property(x => x.LoginProvider).HasColumnName(@"LoginProvider").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProviderKey).HasColumnName(@"ProviderKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserLogins).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
        }
    }

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class CategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
            : this("dbo")
        {
        }

        public CategoryConfiguration(string schema)
        {
            ToTable("Category", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);

            // Foreign keys
            HasOptional(a => a.Parent).WithMany(b => b.Categories).HasForeignKey(c => c.ParentId).WillCascadeOnDelete(false); // FK_Category_Category
        }
    }

    // ImageNews
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class ImageNewConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ImageNew>
    {
        public ImageNewConfiguration()
            : this("dbo")
        {
        }

        public ImageNewConfiguration(string schema)
        {
            ToTable("ImageNews", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NewsId).HasColumnName(@"NewsId").HasColumnType("int").IsOptional();
            Property(x => x.Path).HasColumnName(@"Path").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);

            // Foreign keys
            HasOptional(a => a.Report).WithMany(b => b.ImageNews).HasForeignKey(c => c.NewsId).WillCascadeOnDelete(false); // FK_ImageNews_News
        }
    }

    // Report
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class ReportConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Report>
    {
        public ReportConfiguration()
            : this("dbo")
        {
        }

        public ReportConfiguration(string schema)
        {
            ToTable("Report", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsOptional();
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Body).HasColumnName(@"Body").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ImageId).HasColumnName(@"ImageId").HasColumnType("int").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);

            // Foreign keys
            HasOptional(a => a.AspNetUser).WithMany(b => b.Reports).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false); // FK_News_AspNetUsers
            HasOptional(a => a.Category).WithMany(b => b.Reports).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_News_Category
        }
    }

    #endregion

}
// </auto-generated>

