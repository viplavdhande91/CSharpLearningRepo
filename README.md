
## Event Handling

1. EventHandler is a standard class whose method signature is as given below

```
public delegate void EventHandler(object? sender, EventArgs e);

```


2. Traditional Approach of Event's Publisher class for declaring events.
```
    public delegate void VideoEncoderDelegate(object video,VideoEventArgs e);

    public event VideoEncoderDelegate? videoEncoded;

```

3. Modern Approach equal to  point 2
```
 public event EventHandler<VideoEventArgs>? videoEncoded;

```

4. In the example taken,

 
##### VideoEncoder is Publisher

##### MessageService, EmailService is Subscriber



## Standard Practices

1. Published Subscription activation method must have protected virtual void keywords

```
protected virtual void OnVideoEncoded(Video video)

```


## Notes

1. An event is a wrapper around a delegate. **It depends on the delegate.**

2. Use the **"event"** keyword with the delegate type variable to declare an event.

3. Use built-in delegate EventHandler or EventHandler<TEventArgs> for common events.

4. The publisher class raises an event, and the subscriber class registers for an event and provides the event-handler method

5. The **signature of the handler method** must match the delegate signature.


6. Register with an event using the += operator. Unsubscribe it using the -= operator. Cannot use the = operator.

7. Pass event data using EventHandler<TEventArgs>.

8. Derive EventArgs base class to create a custom event data class.
e.g. Defined in our code.

9. Events can be declared static, virtual, sealed, and abstract.

10. Event handlers are invoked synchronously if there are multiple subscribers.
