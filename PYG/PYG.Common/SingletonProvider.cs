using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace PYG.Common
{
    /// <summary>
    /// 总括来说，为了使用单例基类创建单例类，您需要执行以下操作:
    /// 1) 定义一个派生自SingletonBase [T]的密封类，其中T是您定义的类名。 它确保您不能从此单例类创建子类。
    /// 2) 在类中定义一个无参数的私有构造函数。它确保不能在外部创建此类的实例。
    /// 3) 通过调用Instance属性来访问类的单例实例和公共成员。
    /// </summary>
    /// <typeparam name="T">单例类</typeparam>
    public abstract class SingletonBase<T> where T : class
    {
        #region Properties

        /// <summary>
        /// 获取该类的单例实例。
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
        public static T Instance => SingletonFactory.Instance;

        #endregion

        #region Constructors

        #endregion

        /// <summary>
        /// 创建单例实例的单例类工厂。
        /// </summary>
        private class SingletonFactory
        {
            #region Fields

            /// <summary>
            /// 定义弱引用实例。
            /// </summary>
            //private static WeakReference _instance;

            /// <summary>
            /// 定义强引用实例。
            /// </summary>
            private static T _instance;

            private static object objLock = new object();

            #endregion

            #region Properties

            /// <summary>
            /// 获取实例。
            /// </summary>
            internal static T Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        lock (objLock)
                        {
                            if (_instance == null)
                                _instance = GetInstance();
                        }
                    }
                    return _instance;

                    //if (!(_instance?.Target is T comparer))
                    //{
                    //    comparer = GetInstance();
                    //    _instance = new WeakReference(comparer);
                    //}
                    //return comparer;
                }
            }

            #endregion

            #region Constructors

            /// <summary>
            /// 防止编译器生成默认构造函数。
            /// </summary>
            private SingletonFactory() { }

            /// <summary>
            /// 显式静态构造函数，告诉c#编译器不要将类型标记为BeforeFieldInit。
            /// </summary>
            [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
            static SingletonFactory() { }

            #endregion

            #region Methods

            /// <summary>
            /// 获取特定类型的实例。
            /// </summary>
            /// <returns>The <see cref="T"/></returns>
            [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Type.InvokeMember")]
            private static T GetInstance()
            {
                var theType = typeof(T);
                T inst;
                try
                {
                    inst = (T)theType.InvokeMember(theType.Name,
                            BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.NonPublic, null, null, null,
                            CultureInfo.InvariantCulture);
                }
                catch (MissingMethodException ex)
                {
                    throw new TypeLoadException(
                            string.Format(CultureInfo.CurrentCulture,
                                    "The type '{0}' must have a private constructor to be used in the Singleton pattern.",
                                    theType.FullName), ex);
                }
                return inst;
            }

            #endregion
        }
    }

    /// <summary>
    /// 用于从另一个类创建或获取单例的静态助手。
    /// </summary>
    /// <typeparam name="T">要创建或获取单例的类型。</typeparam>
    public static class SingletonProvider<T> where T : class, new()
    {
        #region Fields

        /// <summary>
        /// 获取给定类型的单例。
        /// </summary>
        private static readonly Lazy<T> _lazy = new Lazy<T>(() =>
        {
            var ins = new T();
            return ins;
        }, true);

        #endregion

        #region Properties

        /// <summary>
        /// 获取给定类型的单例。
        /// </summary>
        public static T Instance => _lazy.Value;

        #endregion
    }

    /// <summary>
    /// 用于从另一个类创建或获取单例的静态助手。
    /// </summary>
    public static class SingletonProvider
    {
        #region Methods

        /// <summary>
        /// 获取指定类型的单例。
        /// </summary>
        /// <typeparam name="TParameter">单例类型。</typeparam>
        /// <returns>The <see cref="TParameter" />单例对象。</returns>
        public static TParameter Get<TParameter>() where TParameter : class, new()
        {
            return SingletonProvider<TParameter>.Instance;
        }

        #endregion
    }
}
