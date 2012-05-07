﻿// Depends on 
//	Knockout
// 	toastr
//	my.sessionHttpService
// ----------------------------------------------
my.speakersVM = (function(ko, ds, toastr) {
    var 
        sessions = ko.observable(),
        activate = function(routeData) {
            ds.getSessions('speakers',
                {
                    success: loadSessions,
                    error: function() { toastr.error('oops!'); }
                })
        },
        loadSessions = function(data) {
            toastr.success('received with ' + data.sessions.length + ' elements');
            sessions(data.sessions);
        };
    return {
        sessions: sessions,
        activate: activate
    }
})(ko, my.sessionDataService, toastr);