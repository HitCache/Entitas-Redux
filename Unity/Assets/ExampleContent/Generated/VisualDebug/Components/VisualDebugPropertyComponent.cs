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
	public ExampleContent.VisualDebugging.PropertyComponent Property { get { return (ExampleContent.VisualDebugging.PropertyComponent)GetComponent(VisualDebugComponentsLookup.Property); } }
	public bool HasProperty { get { return HasComponent(VisualDebugComponentsLookup.Property); } }

	public void AddProperty(string newValue)
	{
		var index = VisualDebugComponentsLookup.Property;
		var component = (ExampleContent.VisualDebugging.PropertyComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PropertyComponent));
		component.value = newValue;
		AddComponent(index, component);
	}

	public void ReplaceProperty(string newValue)
	{
		var index = VisualDebugComponentsLookup.Property;
		var component = (ExampleContent.VisualDebugging.PropertyComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PropertyComponent));
		component.value = newValue;
		ReplaceComponent(index, component);
	}

	public void CopyPropertyTo(ExampleContent.VisualDebugging.PropertyComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.Property;
		var component = (ExampleContent.VisualDebugging.PropertyComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.PropertyComponent));
		component.value = copyComponent.value;
		ReplaceComponent(index, component);
	}

	public void RemoveProperty()
	{
		RemoveComponent(VisualDebugComponentsLookup.Property);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherProperty;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Property
	{
		get
		{
			if (_matcherProperty == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Property);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherProperty = matcher;
			}

			return _matcherProperty;
		}
	}
}
