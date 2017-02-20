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
using Android.Support.V4.App;

using Xamarin.Forms;

namespace NotificationRestartApp.Droid
{
    using Application = Android.App.Application;

    /// <summary>
    /// 
    /// </summary>
    public class DialogServices : IDialogServices
    {
        public DialogServices()
        {
        }

        #region IDialogServices Members

        public void CancelNotification()
        {
            for (int i = 1; i <= 12; i++)
                this.DoCancelNotification(i);
        }

        public void ShowNotification(string title, string content)
        {
            this.DoNotify01(title, content);
            this.DoNotify02(title, content);
            this.DoNotify03(title, content);
            this.DoNotify04(title, content);
            this.DoNotify05(title, content);
            this.DoNotify06(title, content);
            this.DoNotify07(title, content);
            this.DoNotify08(title, content);
            this.DoNotify09(title, content);
            this.DoNotify10(title, content);
            this.DoNotify11(title, content);
            this.DoNotify12(title, content);
        }

        #endregion

        private void DoCancelNotification(int id)
        {
            var context = Application.Context;

            var intent = new Intent(context, typeof(MainActivity))
                .SetAction("LocalNotifierIntent" + id);

            var pendingIntent = PendingIntent.GetBroadcast(context, 0, intent, PendingIntentFlags.CancelCurrent);

            var alarmManager = context.GetSystemService(Context.AlarmService) as AlarmManager;
            alarmManager.Cancel(pendingIntent);

            var notificationManager = NotificationManagerCompat.From(context);
            notificationManager.Cancel(id);
        }

        private void DoNotify01(string title, string content)
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            //Sem especificar nenhum ActivityFlags ...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("01-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(01, builder.Build());
        }
        private void DoNotify02(string title, string content)
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.SingleTop); //Setando ActivityFlags para SingleTop...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("02-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(02, builder.Build());
        }
        private void DoNotify03(string title, string content)
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.PreviousIsTop); //Setando ActivityFlags para PreviousIsTop...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("03-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(03, builder.Build());
        }
        private void DoNotify04(string title, string content) //Sem usar StackBuilder...
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            //Sem especificar nenhum ActivityFlags ...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("04-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(04, builder.Build());
        }
        private void DoNotify05(string title, string content) //Sem usar StackBuilder...
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.SingleTop); //Setando ActivityFlags para SingleTop...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("05-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(05, builder.Build());
        }
        private void DoNotify06(string title, string content) //Sem usar StackBuilder...
        {
            var context = Forms.Context;

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.PreviousIsTop); //Setando ActivityFlags para PreviousIsTop...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("06-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(06, builder.Build());
        }

        private void DoNotify07(string title, string content)
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            //Sem especificar nenhum ActivityFlags ...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("07-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(07, builder.Build());
        }
        private void DoNotify08(string title, string content)
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.SingleTop); //Setando ActivityFlags para SingleTop...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("08-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(08, builder.Build());
        }
        private void DoNotify09(string title, string content)
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.PreviousIsTop); //Setando ActivityFlags para PreviousIsTop...

            var stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(context);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(MainActivity)));
            stackBuilder.AddNextIntent(resultIntent);

            var pendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("09-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(09, builder.Build());
        }
        private void DoNotify10(string title, string content) //Sem usar StackBuilder...
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            //Sem especificar nenhum ActivityFlags ...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("10-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(10, builder.Build());
        }
        private void DoNotify11(string title, string content) //Sem usar StackBuilder...
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.SingleTop); //Setando ActivityFlags para SingleTop...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("11-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(11, builder.Build());
        }
        private void DoNotify12(string title, string content) //Sem usar StackBuilder...
        {
            var context = Application.Context; //Equivalente à Android.App.Application.Context...

            Intent resultIntent = new Intent(context, typeof(MainActivity));
            resultIntent.SetFlags(ActivityFlags.PreviousIsTop); //Setando ActivityFlags para PreviousIsTop...

            var pendingIntent =
                PendingIntent.GetActivity(context, 0, resultIntent, PendingIntentFlags.UpdateCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetContentTitle("12-" + title)
                .SetContentText(content)
                .SetContentIntent(pendingIntent)
                .SetSmallIcon(Resource.Drawable.icon);

            builder.SetOngoing(false);
            builder.SetAutoCancel(true);

            //var manager = NotificationManagerCompat.From(context);
            var manager = (NotificationManager)context.GetSystemService(Context.NotificationService);

            manager.Notify(12, builder.Build());
        }
    }
}