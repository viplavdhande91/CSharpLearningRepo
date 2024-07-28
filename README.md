
## Event Handling

1. **EventHandler** is a standard delegate whose method signature is as given below

```csharp
public delegate void EventHandler(object? sender, EventArgs e);
```


~~2.***Traditional Approach*** of Event's Publisher class for declaring events.~~
```csharp
    public delegate void VideoEncoderDelegate(object video,VideoEventArgs e);

    public event VideoEncoderDelegate? videoEncoded;
```

3. ***Modern Approach*** equal to  point 2
```csharp
 public event EventHandler<VideoEventArgs>? videoEncoded;
```

4. In the example taken,
   - VideoEncoder is Publisher Entity
   - MessageService, EmailService is Subscriber Entity



## Standard Practices

- Publisher's Subscription activation method must have ```protected virtual void``` keywords

```csharp
protected virtual void OnVideoEncoded(Video video)
```


## Notes

1. An event is a wrapper around a delegate. **It depends on the delegate.** In C#, an event is an encapsulated delegate.

2. Use the **"event"** keyword with the delegate type variable to declare an event.

3. Use built-in delegate ```EventHandler``` or ```EventHandler<TEventArgs>``` for common events.

4. The publisher class raises an event, and the subscriber class registers for an event and provides the Event Handler method. The **signature of the event handler method** must match the delegate signature.

5. Register with an event using the ```+=``` operator. Unsubscribe it using the ```-=``` operator. Never use the ```=``` operator.

6. Events can be declared static, virtual, sealed, and abstract.

7. Event handlers are invoked synchronously if there are multiple subscribers.
