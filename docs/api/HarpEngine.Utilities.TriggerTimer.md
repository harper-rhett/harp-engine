# <a id="HarpEngine_Utilities_TriggerTimer"></a> Class TriggerTimer

Namespace: [HarpEngine.Utilities](HarpEngine.Utilities.md)  
Assembly: HarpEngine.dll  

```csharp
public class TriggerTimer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[TriggerTimer](HarpEngine.Utilities.TriggerTimer.md)

#### Inherited Members

[Entity.scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_scene), 
[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.Update\(float\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Update\_System\_Single\_), 
[Entity.Draw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Draw), 
[Entity.DrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnRemove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemove), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Utilities_TriggerTimer__ctor_HarpEngine_Scene_System_Single_"></a> TriggerTimer\(Scene, float\)

```csharp
public TriggerTimer(Scene scene, float triggerSeconds)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

`triggerSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Utilities_TriggerTimer_RemoveOnTriggered"></a> RemoveOnTriggered

```csharp
public bool RemoveOnTriggered
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Utilities_TriggerTimer_OnTriggered"></a> OnTriggered\(\)

```csharp
public virtual void OnTriggered()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Skip"></a> Skip\(\)

```csharp
public void Skip()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Trigger"></a> Trigger\(\)

```csharp
protected void Trigger()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Update_System_Single_"></a> Update\(float\)

```csharp
public override void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Utilities_TriggerTimer_Triggered"></a> Triggered

```csharp
public event TriggerTimer.TriggeredDelegate Triggered
```

#### Event Type

 [TriggerTimer](HarpEngine.Utilities.TriggerTimer.md).[TriggeredDelegate](HarpEngine.Utilities.TriggerTimer.TriggeredDelegate.md)

