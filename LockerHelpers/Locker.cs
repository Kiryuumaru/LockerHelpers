using DisposableHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockerHelpers;

/// <summary>
/// Provides wrapped <see cref="SemaphoreSlim"/> with convenient methods.
/// </summary>
public class Locker : SemaphoreSlim
{
    /// <inheritdoc/>
    public Locker(int initialCount)
        : base(initialCount)
    {

    }

    /// <inheritdoc/>
    public Locker(int initialCount, int maxCount)
        : base(initialCount, maxCount)
    {

    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait()"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait()
    {
        Wait();
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait(int)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait(int millisecondsTimeout)
    {
        Wait(millisecondsTimeout);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait(int, CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait(int millisecondsTimeout, CancellationToken cancellationToken)
    {
        Wait(millisecondsTimeout, cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait(TimeSpan)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait(TimeSpan timeout)
    {
        Wait(timeout);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait(TimeSpan, CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait(TimeSpan timeout, CancellationToken cancellationToken)
    {
        Wait(timeout, cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.Wait(CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public IDisposable GetWait(CancellationToken cancellationToken)
    {
        Wait(cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync()"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync()
    {
        await WaitAsync();
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync(int)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync(int millisecondsTimeout)
    {
        await WaitAsync(millisecondsTimeout);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync(int, CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
    {
        await WaitAsync(millisecondsTimeout, cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync(CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync(CancellationToken cancellationToken)
    {
        await WaitAsync(cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync(TimeSpan)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync(TimeSpan timeout)
    {
        await WaitAsync(timeout);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }

    /// <summary>
    /// The <see cref="SemaphoreSlim.WaitAsync(TimeSpan, CancellationToken)"/> with wrapped <see cref="IDisposable"/> to release on dispose.
    /// </summary>
    /// <returns>The <see cref="Task{TResult}"/> with <see cref="IDisposable"/> that will call the <see cref="SemaphoreSlim.Release()"/> on dispose.</returns>
    public async Task<IDisposable> GetWaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
    {
        await WaitAsync(timeout, cancellationToken);
        return new Disposable(disposing =>
        {
            if (disposing)
            {
                Release();
            }
        });
    }
}
