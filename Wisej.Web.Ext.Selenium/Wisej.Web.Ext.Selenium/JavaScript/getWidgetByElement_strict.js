/* ************************************************************************

   qxwebdriver-java

   http://github.com/qooxdoo/qxwebdriver-java
   http://qooxdoo.org

   Copyright:
     2014 1&1 Internet AG, Germany, http://www.1und1.de

   License:
     LGPL: http://www.gnu.org/licenses/lgpl.html
     EPL: http://www.eclipse.org/org/documents/epl-v10.php
     See the license.txt file in the project's top-level directory for details.

   Authors:
     * Daniel Wagner (danielwagner)

************************************************************************ */

qxwebdriver.getWidgetByElement = function() {
  var widget = null;
  if (!qx.ui) {
    return widget;
  }
  if (typeof qx.ui.core !== 'undefined' && typeof qx.ui.core.Widget !== 'undefined') {
    widget = qx.ui.core.Widget.getWidgetByElement(arguments[0]);
  }
  if (!widget && arguments[0].id && typeof qx.ui.mobile !== 'undefined' && typeof qx.ui.mobile.core !== 'undefined' && typeof qx.ui.mobile.core.Widget !== 'undefined') {
    widget = qx.ui.mobile.core.Widget.getWidgetById(arguments[0].id);
  }

  if (!widget) {
    throw new Error("Could not find a widget for this DOM element!");
  }

  return widget;
};
