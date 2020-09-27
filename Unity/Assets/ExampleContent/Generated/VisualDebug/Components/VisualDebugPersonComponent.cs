//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.PersonComponent Person { get { return (ExampleContent.VisualDebugging.PersonComponent)GetComponent(VisualDebugComponentsLookup.Person); } }
	public bool HasPerson { get { return HasComponent(VisualDebugComponentsLookup.Person); } }

	public void AddPerson(string newGender, string newName)
	{
		var index = VisualDebugComponentsLookup.Person;
		var component = (ExampleContent.VisualDebugging.PersonComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PersonComponent));
		component.gender = newGender;
		component.name = newName;
		AddComponent(index, component);
	}

	public void ReplacePerson(string newGender, string newName)
	{
		var index = VisualDebugComponentsLookup.Person;
		var component = (ExampleContent.VisualDebugging.PersonComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PersonComponent));
		component.gender = newGender;
		component.name = newName;
		ReplaceComponent(index, component);
	}

	public void CopyPersonTo(ExampleContent.VisualDebugging.PersonComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.Person;
		var component = (ExampleContent.VisualDebugging.PersonComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PersonComponent));
		component.gender = copyComponent.gender;
		component.name = copyComponent.name;
		ReplaceComponent(index, component);
	}

	public void RemovePerson()
	{
		RemoveComponent(VisualDebugComponentsLookup.Person);
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
public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherPerson;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Person
	{
		get
		{
			if (_matcherPerson == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Person);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherPerson = matcher;
			}

			return _matcherPerson;
		}
	}
}
