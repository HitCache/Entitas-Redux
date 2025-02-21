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
	public EntitasRedux.Tests.ComponentWithFieldsAndProperties ComponentWithFieldsAndProperties { get { return (EntitasRedux.Tests.ComponentWithFieldsAndProperties)GetComponent(TestComponentsLookup.ComponentWithFieldsAndProperties); } }
	public bool HasComponentWithFieldsAndProperties { get { return HasComponent(TestComponentsLookup.ComponentWithFieldsAndProperties); } }

	public void AddComponentWithFieldsAndProperties(string newPublicField, string newPublicProperty)
	{
		var index = TestComponentsLookup.ComponentWithFieldsAndProperties;
		var component = (EntitasRedux.Tests.ComponentWithFieldsAndProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFieldsAndProperties));
		#if !ENTITAS_REDUX_NO_IMPL
		component.publicField = newPublicField;
		component.publicProperty = newPublicProperty;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceComponentWithFieldsAndProperties(string newPublicField, string newPublicProperty)
	{
		var index = TestComponentsLookup.ComponentWithFieldsAndProperties;
		var component = (EntitasRedux.Tests.ComponentWithFieldsAndProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFieldsAndProperties));
		#if !ENTITAS_REDUX_NO_IMPL
		component.publicField = newPublicField;
		component.publicProperty = newPublicProperty;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyComponentWithFieldsAndPropertiesTo(EntitasRedux.Tests.ComponentWithFieldsAndProperties copyComponent)
	{
		var index = TestComponentsLookup.ComponentWithFieldsAndProperties;
		var component = (EntitasRedux.Tests.ComponentWithFieldsAndProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFieldsAndProperties));
		#if !ENTITAS_REDUX_NO_IMPL
		component.publicField = copyComponent.publicField;
		component.publicProperty = copyComponent.publicProperty;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveComponentWithFieldsAndProperties()
	{
		RemoveComponent(TestComponentsLookup.ComponentWithFieldsAndProperties);
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
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherComponentWithFieldsAndProperties;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> ComponentWithFieldsAndProperties
	{
		get
		{
			if (_matcherComponentWithFieldsAndProperties == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.ComponentWithFieldsAndProperties);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherComponentWithFieldsAndProperties = matcher;
			}

			return _matcherComponentWithFieldsAndProperties;
		}
	}
}
