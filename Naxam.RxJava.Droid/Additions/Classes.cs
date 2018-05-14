using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RX.Observables
{
    partial class AsyncOnSubscribe
    {
        public void Call(Java.Lang.Object p1)
        {
            Call((global::RX.Subscriber)p1);
        }
    }
    partial class SyncOnSubscribe
    {
        public void Call(Java.Lang.Object p1)
        {
            Call((global::RX.Subscriber)p1);
        }
    }
}

namespace RX.Internal.Operators
{
    partial class BlockingOperatorToIterator
    {
        partial class SubscriberIterator
        {
            public override void OnNext(Java.Lang.Object p0)
            {
                OnNext((RX.Notification)p0);
            }
        }
    }
    partial class CompletableOnSubscribeConcat
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class EmptyObservableHolder
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class NeverObservableHolder
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeTimeout
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class OnSubscribeFromArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class CompletableOnSubscribeConcatArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeDelayErrorArray
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeConcatIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMerge
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class CompletableOnSubscribeMergeDelayErrorIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Completable.ICompletableSubscriber)p0);
        }
    }

    partial class OnSubscribeAmb
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeAutoConnect
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeCollect
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFlattenIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromAsync
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeCombineLatest
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDetach
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFilter
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromCallable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeFromIterable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeGroupJoin
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssembly
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssemblyCompletable
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeSingle
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTakeLastOne
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeOnAssemblySingle
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeThrow
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTimerOnce
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeTimerPeriodically
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribePublishMulticast
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeConcatMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeJoin
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeUsing
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeLift
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRange
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDefer
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscription
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscriptionOther
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeDelaySubscriptionWithSelector
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRedo
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeReduce
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeReduceSeed
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OnSubscribeRefCount
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDelay
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAny
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDebounceWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorCast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDebounceWithSelector
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDematerialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMaterialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDistinct
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDistinctUntilChanged
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
        public Java.Lang.Object Call(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            return TryCall(p0, p1);
        }
    }

    partial class OperatorMerge
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoAfterTerminate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnEach
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnRequest
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnSubscribe
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDoOnUnsubscribe
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorEagerConcatMap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithSingleObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithSize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithStartEndObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorBufferWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorDelayWithSelector
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorElementAt
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMapNotification
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorGroupBy
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAll
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorMapPair
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorAsObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorIgnoreElements
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorObsevableOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkip
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipLast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipLastTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureBuffer
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimeInterval
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipWhile
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSerialize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSingle
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorObserveOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSkipUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSubscribeOn
    {
        public void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureDrop
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeLastTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSwitch
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnBackpressureLatest
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeTimed
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSwitchIfEmpty
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeUntil
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakUntilPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTake
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeWhile
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeLast
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorThrottleFirst
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimestamp
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToMap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToMultimap
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToObservableList
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorToObservableSortedList
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorUnsubscribeOn
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSampleWithObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorSampleWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithTime
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithSize
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorScan
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithStartEndObservable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithTime
    {
        //public Java.Lang.Object Call(Java.Lang.Object p0)
        //{
        //	return Call((RX.Subscriber)p0);
        //}
    }

    partial class OperatorWindowWithLatestFrom
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithLatestFromMany
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorZip
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorZipIterable
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWindowWithObservableFactory
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWithLatestFrom
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorWithLatestFromMany
    {
        public void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorRetryWithPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTakeUntilPredicate
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorOnErrorResumeNextViaFunction
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class OperatorTimeoutBase
    {
        public Java.Lang.Object Call(Java.Lang.Object p0)
        {
            return Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeUsing
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOperatorOnErrorResumeNext
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleDoAfterTerminate
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeDelaySubscriptionOther
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }

    partial class SingleOnSubscribeMap
    {
        public unsafe void Call(Java.Lang.Object p0)
        {
            Call((RX.Subscriber)p0);
        }
    }
}
