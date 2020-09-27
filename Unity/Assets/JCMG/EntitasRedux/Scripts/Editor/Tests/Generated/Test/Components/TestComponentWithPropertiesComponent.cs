//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity
{
	public EntitasRedux.Tests.ComponentWithProperties ComponentWithProperties { get { return (EntitasRedux.Tests.ComponentWithProperties)GetComponent(TestComponentsLookup.ComponentWithProperties); } }
	public bool HasComponentWithProperties { get { return HasComponent(TestComponentsLookup.ComponentWithProperties); } }

	public void AddComponentWithProperties(string newPublicProperty)
	{
		var index = TestComponentsLookup.ComponentWithProperties;
		var component = (EntitasRedux.Tests.ComponentWithProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithProperties));
		component.publicProperty = newPublicProperty;
		AddComponent(index, component);
	}

	public void ReplaceComponentWithProperties(string newPublicProperty)
	{
		var index = TestComponentsLookup.ComponentWithProperties;
		var component = (EntitasRedux.Tests.ComponentWithProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithProperties));
		component.publicProperty = newPublicProperty;
		ReplaceComponent(index, component);
	}

	public void CopyComponentWithPropertiesTo(EntitasRedux.Tests.ComponentWithProperties copyComponent)
	{
		var index = TestComponentsLookup.ComponentWithProperties;
		var component = (EntitasRedux.Tests.ComponentWithProperties)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithProperties));
		component.publicProperty = copyComponent.publicProperty;
		ReplaceComponent(index, component);
	}

	public void RemoveComponentWithProperties()
	{
		RemoveComponent(TestComponentsLookup.ComponentWithProperties);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherComponentWithProperties;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> ComponentWithProperties
	{
		get
		{
			if (_matcherComponentWithProperties == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.ComponentWithProperties);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherComponentWithProperties = matcher;
			}

			return _matcherComponentWithProperties;
		}
	}
}
