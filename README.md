# OFFLINE password manager
Store and secure your logins, personal information, credit cards and notes under one password
## How to use
When opening the program for the first time, enter your desired password (password checking for strongness +
additional info about the user will be added later) and that's it. Then you can select what data you would like to
create, type it in and press "Create" and you are done.
## Encryption
### How does it encrypt?
First your data is stored in a JSON file format, later on the file gets encrypted using AES
and to top it off, the contents are encrypted using XOR. You can find the files in the "Data" folder
where the .EXE is located
### How secure is it?
Long story short, nothing is and neither is this. The contents can still be viewed in a memory scanner program
like "Cheat Engine", the program and files are local and secured/encrypted under one password, it is 
gonna be safe unless someone will know your password.
## Bug report
Bug | Information | Fixed?
--- | --- | --- |
1 | If the folders are deleted after closing the login window, program crashes. | Yes
2 | Memory leak when pressing buttons. | No
3 | After pressing delete button the listbox does not refresh | No
