export interface Message {
    id: number;
    senderId: number;
    senderUserName: string;
    senderPhotoUrl: any;
    recipientId: number;
    recipientUsername: string;
    recipientPhotoUrl: string;
    content: string;
    dateRead: Date;
    messageSent: string;
  }
  