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
	public EntitasRedux.Tests.ComponentWithFields ComponentWithFields { get { return (EntitasRedux.Tests.ComponentWithFields)GetComponent(TestComponentsLookup.ComponentWithFields); } }
	public bool HasComponentWithFields { get { return HasComponent(TestComponentsLookup.ComponentWithFields); } }

	public void AddComponentWithFields(string newPublicField)
	{
		var index = TestComponentsLookup.ComponentWithFields;
		var component = (EntitasRedux.Tests.ComponentWithFields)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFields));
		component.publicField = newPublicField;
		AddComponent(index, component);
	}

	public void ReplaceComponentWithFields(string newPublicField)
	{
		var index = TestComponentsLookup.ComponentWithFields;
		var component = (EntitasRedux.Tests.ComponentWithFields)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFields));
		component.publicField = newPublicField;
		ReplaceComponent(index, component);
	}

	public void CopyComponentWithFieldsTo(EntitasRedux.Tests.ComponentWithFields copyComponent)
	{
		var index = TestComponentsLookup.ComponentWithFields;
		var component = (EntitasRedux.Tests.ComponentWithFields)CreateComponent(index, typeof(EntitasRedux.Tests.ComponentWithFields));
		component.publicField = copyComponent.publicField;
		ReplaceComponent(index, component);
	}

	public void RemoveComponentWithFields()
	{
		RemoveComponent(TestComponentsLookup.ComponentWithFields);
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
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherComponentWithFields;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> ComponentWithFields
	{
		get
		{
			if (_matcherComponentWithFields == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.ComponentWithFields);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherComponentWithFields = matcher;
			}

			return _matcherComponentWithFields;
		}
	}
}
