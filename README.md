# Shadow Clone
Backup data to multiple locations, creating redundant copies.

Currently a work in progress, will update this repo as goals are met.  
The plan is to have a source folder, and anything put in this folder (including sub-folders) will sync up with copies in multiple places.  

For example you have hard drives A, B, and C.  
The working folder is on drive A, and as you add items to this folder; they're copied across to drives B, and C.  
Target redundant locations could be a 2nd drive on your computer, a NAS, a wireless drive on your network, a cloud storage product.  

## Supported Redundant Targets

1. Network Path (*WIP*)
2. Google Drive (*TODO*)
3. OneDrive (*TODO*)
4. Dropbox (*TODO*)
5. Amazon Drive (*TODO*)


These targets have been selected, as they're run by large companies unlikely to drop product support anytime soon.  
They also offer a free tier of a few GB each, with the paid option to expand to any required size.  
Support for other providers can be added as use cases arise.

## Future Plans

Add a bit of *noise* to files, to protect against Operating Systems, and cloud products from hashing your data to determine what files you're storing.  
For example adding some filler to the end of a music, or video file.  
Adding an extra pixel width line to an image, adding lorem ipsum to a text file.  
Ideally these modifications are reversible, so you're able to get back the original raw file.  
While encrypting the files is a better solution for privacy, you have to view the files at some point, it's then that your Operating System etc has the opportunity to take a hash of your files.  


Encrypt files before transferring them to redundant locations, with the option of also encrypting the source folder.  
Consider different encryption options, such as password, or certificate.  


Both the file modification, and encryption would be opt-in, as they have the potential to damage / lose your original data.  


## Oustanding Questions

* What happens when a cloud product's credentials expire? (or a drive is dead, or the network is down - etc)
* What action should be taken if one of the redundant copies has different sized files to it's counter parts (which one do we trust)?
* What do we do if one of the targets has full capacity? Do we copy to all other targets, do we abandon the copying altogether?
* If a file is deleted from the source directory, do we delete it from all targets too? What if it was an accident, or a virus?
* If an existing file is modified, do we overwrite the targets with that same file, or do we version files? (i.e. modifying a text file to empty is equivalent to deleting it)
* If the source directory is blown away, what does a restore look like?


### License

This source code is released under the [MIT License](./LICENSE).  