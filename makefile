setup:
	mkdir -p $(GOPATH)/src/github.com/jBugman
	ln -s `pwd` $(GOPATH)/src/github.com/jBugman/gomobile-unity

build:
	ANDROID_HOME=~/Library/Android/sdk gomobile bind -a -target=android github.com/jBugman/gomobile-unity/golib
