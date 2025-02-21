//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

	public TestEntity UniqueEventEntity { get { return GetGroup(TestMatcher.UniqueEvent).GetSingleEntity(); } }
	public EntitasRedux.Tests.UniqueEventComponent UniqueEvent { get { return UniqueEventEntity.UniqueEvent; } }
	public bool HasUniqueEvent { get { return UniqueEventEntity != null; } }

	public TestEntity SetUniqueEvent(string newValue)
	{
		if (HasUniqueEvent)
		{
			throw new JCMG.EntitasRedux.EntitasReduxException(
				"Could not set UniqueEvent!\n" +
				this +
				" already has an entity with EntitasRedux.Tests.UniqueEventComponent!",
				"You should check if the context already has a UniqueEventEntity before setting it or use context.ReplaceUniqueEvent().");
		}
		var entity = CreateEntity();
		#if !ENTITAS_REDUX_NO_IMPL
		entity.AddUniqueEvent(newValue);
		#endif
		return entity;
	}

	public void ReplaceUniqueEvent(string newValue)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		var entity = UniqueEventEntity;
		if (entity == null)
		{
			entity = SetUniqueEvent(newValue);
		}
		else
		{
			entity.ReplaceUniqueEvent(newValue);
		}
		#endif
	}

	public void RemoveUniqueEvent()
	{
		UniqueEventEntity.Destroy();
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity
{
	public EntitasRedux.Tests.UniqueEventComponent UniqueEvent { get { return (EntitasRedux.Tests.UniqueEventComponent)GetComponent(TestComponentsLookup.UniqueEvent); } }
	public bool HasUniqueEvent { get { return HasComponent(TestComponentsLookup.UniqueEvent); } }

	public void AddUniqueEvent(string newValue)
	{
		var index = TestComponentsLookup.UniqueEvent;
		var component = (EntitasRedux.Tests.UniqueEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUniqueEvent(string newValue)
	{
		var index = TestComponentsLookup.UniqueEvent;
		var component = (EntitasRedux.Tests.UniqueEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUniqueEventTo(EntitasRedux.Tests.UniqueEventComponent copyComponent)
	{
		var index = TestComponentsLookup.UniqueEvent;
		var component = (EntitasRedux.Tests.UniqueEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUniqueEvent()
	{
		RemoveComponent(TestComponentsLookup.UniqueEvent);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueEvent;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueEvent
	{
		get
		{
			if (_matcherUniqueEvent == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueEvent);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherUniqueEvent = matcher;
			}

			return _matcherUniqueEvent;
		}
	}
}
