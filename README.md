# RouteIF
Route all the IP traffic from an interface to an other by changing the default route on Windows

Get the list of all available interfaces (`Description` + `Default Gateway`) with the command:
```
> ipconfig /all
```

Get the current default gateway registered with `0.0.0.0` using the command:
```
> route print
```

When changing the item `Description` in the combobox, update the `Default Gateway` with this command:
```
> route change 0.0.0.0 mask 0.0.0.0 <Default Gateway>
```

Note: the  application could be minimized in the system tray.
