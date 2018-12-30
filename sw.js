self.addEventListener('push', function(event) {
  console.log('Received push');
  const notification_payload = JSON.parse(event.data.text())
  console.dir(notification_payload)
  let notificationTitle = 'Hello';
  const notificationOptions = {
    body: 'Thanks for sending this push msg.',
    icon: './images/logo-192x192.png',
    badge: './images/badge-72x72.png',
    tag: 'simple-push-demo-notification',
    data: {
      url: notification_payload.action,
    },
  };


  if (event.data) {
    //const dataText = event.data.text();
    notificationTitle = notification_payload.title;
    notificationOptions.body = notification_payload.body;
    notificationOptions.icon = notification_payload.icon;
    notificationOptions.image = notification_payload.image;
    notificationOptions.tag = notification_payload.title;
    notificationOptions.data.url = notification_payload.action;
  }

 //console.log(notificationOptions)
 console.log(notificationOptions);

  event.waitUntil(
      self.registration.showNotification(
        notificationTitle, notificationOptions)
  );
});

self.addEventListener('notificationclick', function(event) {
  event.notification.close();
  console.log(event)
  let clickResponsePromise = Promise.resolve();
  if (event.notification.data && event.notification.data.url) {
    clickResponsePromise = clients.openWindow(event.notification.data.url);
  }

  // event.waitUntil(
  //   Promise.all([
  //     clickResponsePromise,
  //     self.analytics.trackEvent('notification-click'),
  //   ])
  // );
});


//
// self.addEventListener('notificationclose', function(event) {
//   event.waitUntil(
//     Promise.all([
//       self.analytics.trackEvent('notification-close'),
//     ])
//   );
// });
