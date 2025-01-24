### IProgress Interface

- IProgress<T> can be used to report progress of **some procedure** to **another procedure**. This example shows how you can create a basic method that reports its progress.

### Benefit
-  Long-running operations are typically set up as asynchronous methods to prevent the application from blocking these long processes. In this scenario, it is helpful to have a mechanism to report the progress back to the user, to give them an expectation of the running time. The IProgress interface can be used for that purpose.

