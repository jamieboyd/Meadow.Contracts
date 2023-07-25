using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Meadow;

/// <summary>
/// Represents a collection of services and provides methods to manage and retrieve services from the collection.
/// </summary>
public class ServiceCollection : IEnumerable<object>
{
    private Dictionary<Type, object> m_items = new();

    /// <summary>
    /// Returns an enumerator that iterates through the collection of services.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<object> GetEnumerator()
    {
        return m_items.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Adds a service to the collection.
    /// </summary>
    /// <param name="o">The service object to add.</param>
    public void Add(object o)
    {
        if (o == null)
        {
            throw new ArgumentNullException(nameof(o));
        }

        lock (m_items)
        {
            var t = o.GetType();

            if (m_items.ContainsKey(t))
            {
                throw new ArgumentException($"Object of type {t.Name} is already in the collection.");
            }
            m_items.Add(t, o);
        }
    }

    /// <summary>
    /// Adds a service to the collection and registers it with the specified type.
    /// </summary>
    /// <param name="o">The service object to add.</param>
    /// <param name="registerAs">The type to register the service as.</param>
    public void Add(object o, Type registerAs)
    {
        if (o == null)
        {
            throw new ArgumentNullException(nameof(o));
        }

        lock (m_items)
        {
            if (m_items.ContainsKey(registerAs))
            {
                throw new ArgumentException($"Object of type {registerAs.Name} is already in the collection.");
            }
            m_items.Add(registerAs, o);
        }
    }

    /// <summary>
    /// Determines whether the collection contains a service of the specified registered type.
    /// </summary>
    /// <typeparam name="TRegisteredType">The registered type of the service.</typeparam>
    /// <returns><c>true</c> if the collection contains the service; otherwise, <c>false</c>.</returns>
    public bool ContainsRegisteredType<TRegisteredType>()
    {
        return m_items.ContainsKey(typeof(TRegisteredType));
    }

    /// <summary>
    /// Adds a service to the collection and registers it with the specified type.
    /// </summary>
    /// <typeparam name="TRegisterAs">The type to register the service as.</typeparam>
    /// <param name="o">The service object to add.</param>
    public void Add<TRegisterAs>(TRegisterAs o)
    {
        if (o == null)
        {
            throw new ArgumentNullException(nameof(o));
        }

        lock (m_items)
        {
            var t = typeof(TRegisterAs);

            if (m_items.ContainsKey(t))
            {
                throw new ArgumentException($"Object of type {t.Name} is already in the collection.");
            }
            m_items.Add(t, o);
        }
    }

    /// <summary>
    /// Gets a service of the specified registered type from the collection.
    /// </summary>
    /// <param name="registeredType">The registered type of the service to retrieve.</param>
    /// <returns>The service object if found; otherwise, <c>null</c>.</returns>
    public object? Get(Type registeredType)
    {
        lock (m_items)
        {
            if (m_items.ContainsKey(registeredType))
            {
                return m_items[registeredType];
            }

            return m_items.Values.FirstOrDefault(t => t.GetType().IsAssignableFrom(registeredType));
        }
    }

    /// <summary>
    /// Gets a service of the specified registered type from the collection.
    /// </summary>
    /// <typeparam name="TRegisteredType">The registered type of the service to retrieve.</typeparam>
    /// <returns>The service object if found; otherwise, <c>null</c>.</returns>
    public TRegisteredType? Get<TRegisteredType>()
    {
        var t = typeof(TRegisteredType);
        return (TRegisteredType?)Get(t);
    }

    /// <summary>
    /// Gets or creates a service of the specified type from the collection.
    /// If the service does not exist, a new instance of the specified type is created and added to the collection.
    /// </summary>
    /// <typeparam name="TCreateType">The type of the service to create or retrieve.</typeparam>
    /// <returns>The service object of the specified type.</returns>
    public TCreateType GetOrCreate<TCreateType>()
    {
        var existing = Get<TCreateType>();
        if (existing != null)
        {
            return existing;
        }
        return Create<TCreateType>();
    }

    /// <summary>
    /// Gets or creates a service of the specified creation type and registered type from the collection.
    /// If the service does not exist, a new instance of the creation type is created and added to the collection
    /// and registered with the specified registered type.
    /// </summary>
    /// <typeparam name="TCreateType">The type of the service to create.</typeparam>
    /// <typeparam name="TRegisteredType">The type to register the service as.</typeparam>
    /// <returns>The service object of the specified creation type and registered type.</returns>
    public TRegisteredType GetOrCreate<TCreateType, TRegisteredType>()
        where TCreateType : TRegisteredType
    {
        var existing = Get<TRegisteredType>();
        if (existing != null)
        {
            return existing;
        }
        return Create<TCreateType, TRegisteredType>();
    }

    /// <summary>
    /// Creates and adds a service of the specified type to the collection.
    /// </summary>
    /// <typeparam name="TCreateType">The type of the service to create.</typeparam>
    /// <returns>The created service object.</returns>
    public TCreateType Create<TCreateType>()
    {
        var t = typeof(TCreateType);
        return (TCreateType)Create(t, null);
    }

    /// <summary>
    /// Creates and adds a service of the specified creation type and registered type to the collection.
    /// </summary>
    /// <typeparam name="TCreateType">The type of the service to create.</typeparam>
    /// <typeparam name="TRegisterAs">The type to register the service as.</typeparam>
    /// <returns>The created service object.</returns>
    public TCreateType Create<TCreateType, TRegisterAs>()
        where TCreateType : TRegisterAs
    {
        var t1 = typeof(TCreateType);
        var t2 = typeof(TRegisterAs);
        return (TCreateType)Create(t1, t2);
    }

    /// <summary>
    /// Creates and adds a service of the specified type to the collection.
    /// </summary>
    /// <param name="createType">The type of the service to create.</param>
    /// <returns>The created service object.</returns>
    public object Create(Type createType)
    {
        if (createType == null)
        {
            throw new ArgumentNullException(nameof(createType));
        }

        return Create(createType, null);
    }

    /// <summary>
    /// Creates and adds a service of the specified type to the collection.
    /// </summary>
    /// <param name="createType">The type of the service to create.</param>
    /// <param name="registerType">The type to register the service as.</param>
    /// <returns>The created service object.</returns>
    public object Create(Type createType, Type? registerType)
    {
        if (registerType == null)
        {
            registerType = createType;
        }

        if (!registerType.IsAssignableFrom(createType))
        {
            throw new ArgumentException($"Type {createType.Name} does not inherit from {registerType.Name}");
        }

        var instance = GenerateInstance(createType);

        lock (m_items)
        {
            if (m_items.ContainsKey(registerType))
            {
                throw new ArgumentException($"Object of type {registerType.Name} is already in the collection.");
            }
            m_items.Add(registerType, instance);

            return instance;
        }
    }

    /// <summary>
    /// Creates an instance of the requested type, including any constructor or property injections
    /// </summary>
    /// <param name="createType">The type of the object to create</param>
    /// <returns>An instance of the requested type</returns>
    public object GenerateInstance(Type createType)
    {
        if (createType == null)
        {
            throw new ArgumentNullException(nameof(createType));
        }

        // get the object's constructor(s)
        var ctors = createType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        // prefer a parameterless ctor
        var ctor = ctors.FirstOrDefault(c => c.GetParameters().Length == 0);
        object? instance;
        if (ctor == null)
        {
            instance = DoConstructorInjections(ctors);
        }
        else
        {
            instance = ctor.Invoke(null);
        }

        if (instance == null)
        {
            // TODO: look for a ctor we have enough info to inject into
            throw new Exception($"No parameterless constructor or injectable constructor found for {createType.Name}");
        }

        DoPropertyInjections(instance);

        return instance;
    }

    private object? DoConstructorInjections(IEnumerable<ConstructorInfo> ctors)
    {
        List<object> pList = new List<object>();

        foreach (var c in ctors)
        {
            pList.Clear();
            var valid = true;

            foreach (var p in c.GetParameters())
            {
                var inject = m_items.Values.FirstOrDefault(i => p.ParameterType.IsAssignableFrom(i.GetType()));
                if (inject == null)
                {
                    valid = false;
                    break;
                }
                else
                {
                    pList.Add(inject);
                }
            }

            if (valid)
            {
                return c.Invoke(pList.ToArray());
            }
        }
        return null;
    }

    private void DoPropertyInjections(object instance)
    {
        // Do basic property injection
        var settableProps = instance.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
            .Where(p => p.SetMethod != null);

        foreach (var p in settableProps)
        {
            var inject = m_items.Values.FirstOrDefault(i => p.PropertyType.IsAssignableFrom(i.GetType()));
            if (inject != null)
            {
                // only inject if the property value is null (or has no getter)
                if ((p.GetMethod == null) || (p.GetMethod.Invoke(instance, null) == null))
                {
                    p.SetMethod?.Invoke(instance, new object[] { inject });
                }
            }
        }
    }
}
